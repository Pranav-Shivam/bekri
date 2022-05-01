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
    public partial class Form1 : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public Form1()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\CSharp\MyC#Program\BekriShop\BekriShop\DataBase\LoginDB.mdb";
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Black;
            txtUser.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F4 = new Form4();
            F4.ShowDialog();
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Please Enter User Name First", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtUser.Focus();
            }
            else
            {
                conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = conn;
                Cmd.CommandText = "Select * From LoginTable where UserName='" + txtUser.Text + "'";
                OleDbDataReader Rd = Cmd.ExecuteReader();
                if (Rd.Read())
                {
                    this.Hide();
                    Form3 F3 = new Form3();
                    F3.txtName.Text = txtUser.Text;
                    F3.ShowDialog();
                }
                else
                {

                    MessageBox.Show("User Name Does not Exist", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    conn.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from LoginTable where UserName= '" + txtUser.Text + "' and Password = '" + txtPassword.Text + "'";
            OleDbDataReader Rs = cmd.ExecuteReader();
            int i = 0;
            while (Rs.Read())
            {
                i = i + 1;
            }
            if (i==1)
            {
                this.Hide();
                Form2 F2=new Form2();
                F2.ShowDialog();
            }
            else
                MessageBox.Show("Incorrect User Name Or Password");
                conn.Close();

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
