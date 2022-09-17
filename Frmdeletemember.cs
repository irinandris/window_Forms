using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1205
{
    public partial class Frmdeletemember : Form
    {
        Database.DatabaseProcess db = new Database.DatabaseProcess();
        string sql = "";
        public Frmdeletemember()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //db.connect();
            //db.DeleteSQL(sql);
            //label1.Text = $"Member ID: {dataGridView1.SelectedCells[0].Value.ToString()} has been deleted";

            db.connect();
            sql = $"DELETE from Member WHERE Member_id  = {dataGridView1.SelectedCells[0].Value.ToString()}";
            if (dataGridView1.SelectedCells[0].Value.ToString() == "")
            {
                MessageBox.Show("Please select to Member ID you wish to delete.");
            }

            if (MessageBox.Show("Want to Member !!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    sql = $"DELETE from Member WHERE Member_id  = {dataGridView1.SelectedCells[0].Value.ToString()}";
                    db.DeleteSQL(sql);
                    DataTable dataTable = new DataTable();
                    dataTable.Load(db.DisCart());
                    dataGridView1.DataSource = dataTable;
                    label2.Text = $"Member : {dataGridView1.SelectedCells[0].Value.ToString()} has been deleted";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            db.disConnection();
        }
        private void Frmdeletemember_Load(object sender, EventArgs e)
        {
            db.connect();
            DataTable dataTable = new DataTable();
            dataTable.Load(db.loadmember());
            dataGridView1.DataSource = dataTable;
            db.disConnection();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            sql = $"DELETE from Member WHERE Member_id  = {dataGridView1.SelectedCells[0].Value.ToString()}";
            textBox1.Text = sql;
        }
    }
}
