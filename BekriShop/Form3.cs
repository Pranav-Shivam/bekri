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
    public partial class Form3 : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public Form3()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\MyC#Program\BekriShop\BekriShop\DataBase\LoginDB.mdb";
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = " select * from LoginTable where UserName = '" + txtName.Text + "' and Mobile = " + txtMobile.Text + " and EmailID = '" + txtEmail.Text + "'";
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                label5.Visible = true;
                label6.Visible = true;
                txtRenewpass.Visible = true;
                btnBack.Visible = true;
                txtNewPass.Text = (rd[2].ToString());
                txtRenewpass.Text = (rd[2].ToString());
            }
            else
            {
                MessageBox.Show(" Incorrect Email or Mobile no. please check ");
                txtEmail.Text= "";
                txtMobile.Text= "";
            }
            conn.Close();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtRenewpass.Text)
            {

                MessageBox.Show(" password doesn't match please enter correct password ", "Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtNewPass.Focus();
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update LoginTable SET Password = '" + txtNewPass.Text + "' where UserName = '" + txtEmail.Text + "' ";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(" Your Password is changed succefully .");
            }
            
       }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
