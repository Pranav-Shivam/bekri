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
    public partial class Form5 : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public Form5()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\MyC#Program\BekriShop\BekriShop\DataBase\LoginDB.mdb";
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "PA Black Forest";
            double MRP = 450;
            string Qnty = txtOne.Text;
            if (txtOne.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtOne.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 450;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + Qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txtOne.Text = "";
                txtOne.Focus();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Pine Apple cake";
            double MRP = 350;
            string qnty = txtTwo.Text;
            if (txtTwo.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtTwo.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(qnty) * 350;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txtTwo.Text = "";
                txtTwo.Focus();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Chocolate cake";
            double MRP = 420;
            string qnty = txtThree.Text;
            if (txtThree.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtThree.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(qnty) * 420;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txtThree.Text = "";
                txtThree.Focus();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Vanela cake";
            double MRP = 400;
            string qnty = txtFour.Text;
            if (txtFour.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtFour.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(qnty) * 400;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txtFour.Text = "";
                txtFour.Focus();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Ice Cream cake";
            double MRP = 520;
            string qnty = txtFive.Text;
            if (txtFive.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtFive.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(qnty) * 520;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txtFive.Text = "";
                txtFive.Focus();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Black Forest";
            double MRP = 450;
            string qnty = txtSix.Text;
            if (txtSix.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtSix.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(qnty) * 450;
                Class1.TotalVar = Class1.TotalVar + amount;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bill Values('" + item + "'," + MRP + ",'" + qnty + "'," + amount + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                txtSix.Text = "";
                txtSix.Focus();
            }
        }
    }
}
