namespace PVCWindowsStudio.UI
{
    partial class RolesForm
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.roleGridView = new Telerik.WinControls.UI.RadGridView();
            this.gridViewTemplate1 = new Telerik.WinControls.UI.GridViewTemplate();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radValidationProvider1 = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.radPanel6 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel6)).BeginInit();
            this.radPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 36);
            this.txtName.TabIndex = 0;
            this.txtName.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtName, radValidationRule1);
            // 
            // roleGridView
            // 
            this.roleGridView.AutoScroll = true;
            this.roleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.roleGridView.MasterTemplate.AllowAddNewRow = false;
            this.roleGridView.MasterTemplate.AllowDeleteRow = false;
            this.roleGridView.MasterTemplate.AllowEditRow = false;
            this.roleGridView.MasterTemplate.AllowSearchRow = true;
            this.roleGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.roleGridView.MasterTemplate.EnablePaging = true;
            this.roleGridView.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate1});
            this.roleGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.roleGridView.Name = "roleGridView";
            this.roleGridView.Size = new System.Drawing.Size(852, 704);
            this.roleGridView.TabIndex = 0;
            this.roleGridView.ThemeName = "MaterialBlueGrey";
            this.roleGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.roleGridView_CellDoubleClick);
            // 
            // gridViewTemplate1
            // 
            this.gridViewTemplate1.ViewDefinition = tableViewDefinition1;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPanel5);
            this.radPanel1.Controls.Add(this.radPanel4);
            this.radPanel1.Controls.Add(this.radPanel3);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel1.Location = new System.Drawing.Point(852, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(289, 704);
            this.radPanel1.TabIndex = 2;
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.lblID);
            this.radPanel5.Controls.Add(this.lblUserName);
            this.radPanel5.Controls.Add(this.txtName);
            this.radPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel5.Location = new System.Drawing.Point(0, 52);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(289, 449);
            this.radPanel5.TabIndex = 2;
            this.radPanel5.ThemeName = "MaterialBlueGrey";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 148);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 22);
            this.lblID.TabIndex = 5;
            this.lblID.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(26, 41);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Role Name";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.btnClear);
            this.radPanel4.Controls.Add(this.btnDelete);
            this.radPanel4.Controls.Add(this.btnUpdate);
            this.radPanel4.Controls.Add(this.btnSave);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel4.Location = new System.Drawing.Point(0, 501);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(289, 203);
            this.radPanel4.TabIndex = 2;
            this.radPanel4.ThemeName = "MaterialBlueGrey";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnClear.Image = global::PVCWindowsStudio.Properties.Resources.eraser__1_;
            this.btnClear.Location = new System.Drawing.Point(8, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(269, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.ThemeName = "MaterialBlueGrey";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnClear.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.eraser__1_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnClear.GetChildAt(0))).Text = "CLEAR";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnClear.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnClear.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnClear.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnDelete.Image = global::PVCWindowsStudio.Properties.Resources.trash;
            this.btnDelete.Location = new System.Drawing.Point(8, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(269, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.ThemeName = "MaterialBlueGrey";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDelete.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.trash;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDelete.GetChildAt(0))).Text = "DELETE";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnUpdate.Image = global::PVCWindowsStudio.Properties.Resources.pencil;
            this.btnUpdate.Location = new System.Drawing.Point(8, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(269, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.ThemeName = "MaterialBlueGrey";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnUpdate.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.pencil;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnUpdate.GetChildAt(0))).Text = "UPDATE";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnUpdate.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnUpdate.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnUpdate.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnUpdate.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSave.Image = global::PVCWindowsStudio.Properties.Resources.plus__3_;
            this.btnSave.Location = new System.Drawing.Point(8, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(269, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.ThemeName = "MaterialBlueGrey";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.plus__3_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "SAVE";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.label1);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel3.Location = new System.Drawing.Point(0, 0);
            this.radPanel3.Name = "radPanel3";
            // 
            // 
            // 
            this.radPanel3.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.radPanel3.Size = new System.Drawing.Size(289, 52);
            this.radPanel3.TabIndex = 2;
            this.radPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanel3.ThemeName = "MaterialBlueGrey";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPanel2
            // 
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1141, 704);
            this.radPanel2.TabIndex = 3;
            // 
            // radValidationProvider1
            // 
            this.radValidationProvider1.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.txtName);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule1.ToolTipText = "Name can\'t be empty!";
            radValidationRule1.Value = "";
            this.radValidationProvider1.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});
            // 
            // radPanel6
            // 
            this.radPanel6.Controls.Add(this.roleGridView);
            this.radPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel6.Location = new System.Drawing.Point(0, 0);
            this.radPanel6.Name = "radPanel6";
            this.radPanel6.Size = new System.Drawing.Size(852, 704);
            this.radPanel6.TabIndex = 4;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 704);
            this.Controls.Add(this.radPanel6);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RolesForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RolesForm";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            this.radPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel6)).EndInit();
            this.radPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView roleGridView;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private System.Windows.Forms.Label lblUserName;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate1;
        private Telerik.WinControls.UI.RadValidationProvider radValidationProvider1;
        private System.Windows.Forms.Label lblID;
        private Telerik.WinControls.UI.RadPanel radPanel6;
    }
}
