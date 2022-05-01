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
    public partial class Form10 : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public Form10()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\MyC#Program\BekriShop\BekriShop\DataBase\LoginDB.mdb";
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Cadebery Celebration ";
            double MRP = 250;
            string Qnty = txt1.Text;
            if (txt1.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt1.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 250;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + Qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txt1.Text = "";
                txt1.Focus();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Dairy milk silk ";
            double MRP = 80;
            string Qnty = txt2.Text;
            if (txt2.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt2.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 80;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + Qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txt2.Text = "";
                txt2.Focus();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "% Star ";
            double MRP = 10;
            string Qnty = txt3.Text;
            if (txt3.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt3.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 10;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + Qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txt3.Text = "";
                txt3.Focus();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Dovida";
            double MRP = 300;
            string Qnty = txt4.Text;
            if (txt4.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt4.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 400;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + Qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txt4.Text = "";
                txt4.Focus();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Green Black Dark ";
            double MRP = 110;
            string Qnty = txt5.Text;
            if (txt5.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt5.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 110;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + Qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txt5.Text = "";
                txt5.Focus();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Snikers";
            double MRP = 40;
            string Qnty = txt6.Text;
            if (txt6.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt6.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 40;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + Qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txt6.Text = "";
                txt6.Focus();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
