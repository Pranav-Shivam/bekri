using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BekriShop
{
    public partial class Bill : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public Bill()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\MyC#Program\BekriShop\BekriShop\DataBase\LoginDB.mdb";
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet8.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter1.Fill(this.loginDBDataSet8.Bill);
            // TODO: This line of code loads data into the 'loginDBDataSet7.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.loginDBDataSet7.Bill);
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from Bill ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }


        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
