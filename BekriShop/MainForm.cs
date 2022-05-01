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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.MdiParent = this;
            f11.Show();
        }

        
        
        private void cakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
        }

       
        private void iceCreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.MdiParent = this;
            f6.Show();
        }

       
        private void sweetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.MdiParent = this;
            f7.Show();
        }

       
        private void coldDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.MdiParent = this;
            f8.Show();
        }

      
        private void fastFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.MdiParent = this;
            f9.Show();
        }

       
        private void choclatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.MdiParent = this;
            f10.Show();
        }

        private void aboutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.MdiParent = this;
            f14.Show();
        }

       
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do You Want to Log Out From Application", "Message ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
