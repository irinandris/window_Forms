using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PAYMENT
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Credit frm = new Credit();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cash frm = new Cash();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OracleConfiguration.TnsAdmin = @"C:\Users\home\Oracle\network\admin\DB202202241350";
            OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;
        }
    }
}
