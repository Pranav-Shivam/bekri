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
    public partial class Form11 : Form
    {
        public OleDbConnection conn = new OleDbConnection();
        public double SubTotal = 0.0;
        public double tax =0.0;
        public double Total = 0.0;
        public Form11()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\MyC#Program\BekriShop\BekriShop\DataBase\LoginDB.mdb";
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.MdiParent = this.ParentForm;
            f9.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void ListBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBill_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet6.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter4.Fill(this.loginDBDataSet6.Bill);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string comd = " Delete from Bill ";
            OleDbCommand cmd = new OleDbCommand(comd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            Class1.TotalVar = 0.0;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string comd = " Delete from Bill ";
            OleDbCommand cmd = new OleDbCommand(comd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            Class1.TotalVar = 0.0;

        }

        private void picIceCream(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this.ParentForm;
            f5.Show();
        }

        private void picCake_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void picCake_click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void picIce_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.MdiParent = this.ParentForm;
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {

                    OleDbCommand cmd = new OleDbCommand();
                    if (dataGridView1.Rows.Count > 1)
                    {
                        Class1.TotalVar = Class1.TotalVar - Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value);
                        cmd.CommandText = " Delete from Bill where item = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        txtTotal.Text = "";
                        txtGst.Text = "";
                        txtTtl.Text = "";

                    }
                    else
                    {
                        MessageBox.Show(" Please select an item ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Please select an item ");
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtMobile.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show(" Please enter name mobile or address of customer ", " Message ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                txtTotal.Text = Convert.ToString(Class1.TotalVar);
                double gst = (Class1.TotalVar * 6) / 100;
                double ttl = Class1.TotalVar + gst;
                txtGst.Text = Convert.ToString(gst);
                txtTtl.Text = Convert.ToString(ttl);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.MdiParent = this.ParentForm;
            f10.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.MdiParent = this.ParentForm;
            f7.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.MdiParent = this.ParentForm;
            f8.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  MainForm m = new MainForm();
            Bill b = new Bill();
            b.txtSubTotal.Text  = Convert.ToString(Class1.TotalVar) ;
            b.txtTotal.Text  = txtTtl.Text;
            b.txtGst.Text  = txtGst.Text;
            b.txtName.Text = txtName.Text;
            b.txtMobile.Text = txtMobile.Text;
         //   b.MdiParent = m;
            b.Show();
        }
    }
}
