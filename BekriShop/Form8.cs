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
    public partial class Form8 : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public Form8()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\MyC#Program\BekriShop\BekriShop\DataBase\LoginDB.mdb";
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Limca";
            double MRP = 35;
            string Qnty = txt5.Text;
            if (txt5.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt5.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 35;
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

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "CocaCola";
            double MRP = 35;
            string Qnty = txt1.Text;
            if (txt1.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt1.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 35;
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

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Sprite";
            double MRP = 35;
            string Qnty = txt2.Text;
            if (txt2.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt2.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 35;
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

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Thums Up Charged";
            double MRP = 45;
            string Qnty = txt3.Text;
            if (txt3.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt3.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 45;
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

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Mountain Due";
            double MRP = 35;
            string Qnty = txt4.Text;
            if (txt4.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt4.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 35;
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

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string item = "Mazza ";
            double MRP = 25;
            string Qnty = txt6.Text;
            if (txt6.Text == "")
            {
                MessageBox.Show(" Please Enter Quantity First ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt6.Focus();
            }
            else
            {
                double amount = Convert.ToDouble(Qnty) * 25;
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
    }
}
