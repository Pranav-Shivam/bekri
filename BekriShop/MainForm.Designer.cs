namespace BekriShop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iceCreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sweetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coldDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choclatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.itemsMenuToolStripMenuItem,
            this.aboutProjectToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(979, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(128, 39);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // itemsMenuToolStripMenuItem
            // 
            this.itemsMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cakesToolStripMenuItem,
            this.iceCreamToolStripMenuItem,
            this.sweetsToolStripMenuItem,
            this.coldDrinksToolStripMenuItem,
            this.fastFoodToolStripMenuItem,
            this.choclatesToolStripMenuItem});
            this.itemsMenuToolStripMenuItem.Name = "itemsMenuToolStripMenuItem";
            this.itemsMenuToolStripMenuItem.Size = new System.Drawing.Size(164, 39);
            this.itemsMenuToolStripMenuItem.Text = "Items Menu";
            // 
            // cakesToolStripMenuItem
            // 
            this.cakesToolStripMenuItem.Name = "cakesToolStripMenuItem";
            this.cakesToolStripMenuItem.Size = new System.Drawing.Size(223, 40);
            this.cakesToolStripMenuItem.Text = "Cakes";
            this.cakesToolStripMenuItem.Click += new System.EventHandler(this.cakesToolStripMenuItem_Click);
            // 
            // iceCreamToolStripMenuItem
            // 
            this.iceCreamToolStripMenuItem.Name = "iceCreamToolStripMenuItem";
            this.iceCreamToolStripMenuItem.Size = new System.Drawing.Size(223, 40);
            this.iceCreamToolStripMenuItem.Text = "Ice-Cream";
            this.iceCreamToolStripMenuItem.Click += new System.EventHandler(this.iceCreamToolStripMenuItem_Click);
            // 
            // sweetsToolStripMenuItem
            // 
            this.sweetsToolStripMenuItem.Name = "sweetsToolStripMenuItem";
            this.sweetsToolStripMenuItem.Size = new System.Drawing.Size(223, 40);
            this.sweetsToolStripMenuItem.Text = "Sweets";
            this.sweetsToolStripMenuItem.Click += new System.EventHandler(this.sweetsToolStripMenuItem_Click);
            // 
            // coldDrinksToolStripMenuItem
            // 
            this.coldDrinksToolStripMenuItem.Name = "coldDrinksToolStripMenuItem";
            this.coldDrinksToolStripMenuItem.Size = new System.Drawing.Size(223, 40);
            this.coldDrinksToolStripMenuItem.Text = "Cold Drinks";
            this.coldDrinksToolStripMenuItem.Click += new System.EventHandler(this.coldDrinksToolStripMenuItem_Click);
            // 
            // fastFoodToolStripMenuItem
            // 
            this.fastFoodToolStripMenuItem.Name = "fastFoodToolStripMenuItem";
            this.fastFoodToolStripMenuItem.Size = new System.Drawing.Size(223, 40);
            this.fastFoodToolStripMenuItem.Text = "Fast Food";
            this.fastFoodToolStripMenuItem.Click += new System.EventHandler(this.fastFoodToolStripMenuItem_Click);
            // 
            // choclatesToolStripMenuItem
            // 
            this.choclatesToolStripMenuItem.Name = "choclatesToolStripMenuItem";
            this.choclatesToolStripMenuItem.Size = new System.Drawing.Size(223, 40);
            this.choclatesToolStripMenuItem.Text = "Choclates";
            this.choclatesToolStripMenuItem.Click += new System.EventHandler(this.choclatesToolStripMenuItem_Click);
            // 
            // aboutProjectToolStripMenuItem
            // 
            this.aboutProjectToolStripMenuItem.Name = "aboutProjectToolStripMenuItem";
            this.aboutProjectToolStripMenuItem.Size = new System.Drawing.Size(189, 39);
            this.aboutProjectToolStripMenuItem.Text = "About Project";
            this.aboutProjectToolStripMenuItem.Click += new System.EventHandler(this.aboutProjectToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(118, 39);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 587);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "                                                                                 " +
                "              Gokul Bakery Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iceCreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sweetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coldDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choclatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}