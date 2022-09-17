using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAYMENT
{
    public partial class Credit : Form
    {
        PAYMENT.DatabasePayment db = new DatabasePayment();
        public Credit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Credit_Load(object sender, EventArgs e)
        {
            db.connect();
            DataTable dataTable = new DataTable();
            dataTable.Load(db.PAYMENT());
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();

            db.connect();
            DataTable dataTable1 = new DataTable();
            dataTable1.Load(db.CREDIT());
            dataGridView2.DataSource = dataTable1;
            dataGridView2.Refresh();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
