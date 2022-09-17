using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PAYMENT
{
    class DatabasePayment
    {
        OracleConnection conn = new OracleConnection(); // on declare
        public int count = 0;
        public DatabasePayment()
        {

        }
        public string connect()
        {
            string state = "", dSource, ChaineConnect;
            try
            {
                OracleConfiguration.TnsAdmin = @"C:\Users\home\Oracle\network\admin\DB202202241350"; ;//porperty
                OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;
            }
            catch (Exception e)
            {
                //database already has been connected.
            }

            conn = new OracleConnection(); //สร้าง instance
            dSource = "(description= (retry_count=20)(retry_delay=3)(connection_timeout=240)(address=(protocol=tcps)(port =1522)(host=adb.ap-seoul-1.oraclecloud.com))(connect_data=(service_name=aixfsmupi1dbjf1_db202202241350_tp.adb.oraclecloud.com))(security=(ssl_server_cert_dn=\"CN = adb.ap-seoul-1.oraclecloud.com, OU = Oracle ADB SEOUL, O = Oracle Corporation, L = Redwood City, ST = California, C = US\")))";

            ChaineConnect = "Data Source =" + dSource
            + "Min Pool Size=10;Connection Lifetime=100000;Connection Timeout=240;User ID=ora2;Password=19i@Mahanakorn@2022";

            conn.ConnectionString = ChaineConnect; //กำหนดค่าการเชื่อมต่อฐานข้อมูล
            conn.Open();
            state = conn.State.ToString();
            if (state == "Open")
                return "Database has been connected.";
            else return "Database cannot be connect.";
        }
        public OracleDataReader PAYMENT()
        {
            OracleCommand command = conn.CreateCommand();
            OracleDataReader dtReader;
            command.CommandText = "select * from PAYMENT";
            return dtReader = command.ExecuteReader();
        }
        public OracleDataReader CREDIT()
        {
            OracleCommand command = conn.CreateCommand();
            OracleDataReader dtReader;
            command.CommandText = "select * from CREDIT";
            return dtReader = command.ExecuteReader();
        }
        public OracleDataReader CASH()
        {
            OracleCommand command = conn.CreateCommand();
            OracleDataReader dtReader;
            command.CommandText = "select * from CASH";
            return dtReader = command.ExecuteReader();
        }
        public int ExecuteSQL(string sql)
        {
            OracleCommand command = conn.CreateCommand();
            command.CommandText = sql;
            int numResult = command.ExecuteNonQuery();
            return numResult;
        }
    }

}
