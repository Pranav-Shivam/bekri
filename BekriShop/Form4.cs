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
    public partial class Form4 : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public Form4()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\CSharp\MyC#Program\BekriShop\BekriShop\DataBase\LoginDB.mdb";
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtPassword.Text == "" && txtBirth.Text == "" && txtMobile.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Oops Something Went Wrong");
                txtUserName.Focus();
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into LoginTable Values('" + txtUserName.Text + "','" + txtBirth.Text + "','" + txtPassword.Text + "'," + txtMobile.Text + ",'" + txtEmail.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Congratulation You Are Register Successfully");
            }
            txtUserName.Text = "";
            txtBirth.Text = "";
            txtPassword.Text="";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
