using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BekriShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
            label3.Text = progressBar1.Value + "%";
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                this.Hide();
                MainForm mx = new MainForm();
                mx.ShowDialog();
            }

        }
    }
}
