namespace PVCWindowsStudio.UI
{
    partial class Menu
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
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard2MenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.calculatorMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.orderHistoryMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.orderMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.orderDetailsMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.invoicesMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.clientsMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.panelChildForm = new Telerik.WinControls.UI.RadPanel();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblUserStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PVCWindowsStudio.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(494, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard2MenuItem
            // 
            this.dashboard2MenuItem.Name = "dashboard2MenuItem";
            this.dashboard2MenuItem.Text = "Dashboard";
            this.dashboard2MenuItem.UseCompatibleTextRendering = false;
            this.dashboard2MenuItem.Click += new System.EventHandler(this.dashboard2MenuItem_Click);
            // 
            // calculatorMenuItem
            // 
            this.calculatorMenuItem.Name = "calculatorMenuItem";
            this.calculatorMenuItem.Text = "Calculator";
            this.calculatorMenuItem.UseCompatibleTextRendering = false;
            this.calculatorMenuItem.Click += new System.EventHandler(this.calculatorMenuItem_Click);
            // 
            // orderHistoryMenuItem
            // 
            this.orderHistoryMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.orderMenuItem,
            this.orderDetailsMenuItem});
            this.orderHistoryMenuItem.Name = "orderHistoryMenuItem";
            this.orderHistoryMenuItem.Text = "Order History";
            this.orderHistoryMenuItem.UseCompatibleTextRendering = false;
            // 
            // orderMenuItem
            // 
            this.orderMenuItem.Name = "orderMenuItem";
            this.orderMenuItem.Text = "Order";
            this.orderMenuItem.UseCompatibleTextRendering = false;
            this.orderMenuItem.Click += new System.EventHandler(this.orderMenuItem_Click);
            // 
            // orderDetailsMenuItem
            // 
            this.orderDetailsMenuItem.Name = "orderDetailsMenuItem";
            this.orderDetailsMenuItem.Text = "Order Details";
            this.orderDetailsMenuItem.UseCompatibleTextRendering = false;
            this.orderDetailsMenuItem.Click += new System.EventHandler(this.orderDetailsMenuItem_Click);
            // 
            // invoicesMenuItem
            // 
            this.invoicesMenuItem.Name = "invoicesMenuItem";
            this.invoicesMenuItem.Text = "Invoices";
            this.invoicesMenuItem.UseCompatibleTextRendering = false;
            this.invoicesMenuItem.Click += new System.EventHandler(this.invoicesMenuItem_Click);
            // 
            // clientsMenuItem
            // 
            this.clientsMenuItem.Name = "clientsMenuItem";
            this.clientsMenuItem.Text = "Clients";
            this.clientsMenuItem.UseCompatibleTextRendering = false;
            this.clientsMenuItem.Click += new System.EventHandler(this.clientsMenuItem_Click);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Logout";
            this.radMenuItem1.UseCompatibleTextRendering = false;
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 37);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1081, 665);
            this.panelChildForm.TabIndex = 22;
            this.panelChildForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelChildForm.ThemeName = "MaterialBlueGrey";
            this.panelChildForm.Visible = false;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.dashboard2MenuItem,
            this.calculatorMenuItem,
            this.orderHistoryMenuItem,
            this.invoicesMenuItem,
            this.clientsMenuItem,
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1081, 37);
            this.radMenu1.TabIndex = 19;
            this.radMenu1.ThemeName = "MaterialBlueGrey";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::PVCWindowsStudio.Properties.Resources.user11;
            this.pictureBox2.Location = new System.Drawing.Point(1019, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 67);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label11.Location = new System.Drawing.Point(912, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Welcome";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(913, 65);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 23);
            this.lblUserName.TabIndex = 25;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Controls.Add(this.lblUserStatus);
            this.radPanel1.Location = new System.Drawing.Point(0, 664);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1081, 40);
            this.radPanel1.TabIndex = 28;
            this.radPanel1.ThemeName = "MaterialBlueGrey";
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUserStatus.Location = new System.Drawing.Point(3, 6);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(120, 23);
            this.lblUserStatus.TabIndex = 3;
            this.lblUserStatus.Text = "Status : Admin";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 702);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Dashboard2";
            this.ThemeName = "MaterialBlueGrey";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadMenuItem dashboard2MenuItem;
        private Telerik.WinControls.UI.RadMenuItem calculatorMenuItem;
        private Telerik.WinControls.UI.RadMenuItem orderHistoryMenuItem;
        private Telerik.WinControls.UI.RadMenuItem orderMenuItem;
        private Telerik.WinControls.UI.RadMenuItem orderDetailsMenuItem;
        private Telerik.WinControls.UI.RadMenuItem invoicesMenuItem;
        private Telerik.WinControls.UI.RadMenuItem clientsMenuItem;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadPanel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUserName;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblUserStatus;
    }
}
