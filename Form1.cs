using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1205
{
    public partial class Form1 : Form
    {
        Database.DatabaseProcess db = new Database.DatabaseProcess();
        public string sql = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAddMember f = new FrmAddMember();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmshop f = new Frmshop();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmShippingCast f = new FrmShippingCast();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Maincs f = new Maincs();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
