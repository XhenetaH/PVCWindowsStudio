namespace PVCWindowsStudio.UI
{
    partial class ProductsForm
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
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.productGridView = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnRemove = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.productPictureBox = new Telerik.WinControls.UI.RadPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.radValidationProvider1 = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 299);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 41);
            this.txtName.TabIndex = 0;
            this.txtName.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtName, radValidationRule1);
            // 
            // productGridView
            // 
            this.productGridView.BackColor = System.Drawing.Color.White;
            this.productGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.productGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.productGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.productGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productGridView.Location = new System.Drawing.Point(0, 0);
            this.productGridView.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.productGridView.MasterTemplate.AllowAddNewRow = false;
            this.productGridView.MasterTemplate.AllowDeleteRow = false;
            this.productGridView.MasterTemplate.AllowEditRow = false;
            this.productGridView.MasterTemplate.AllowSearchRow = true;
            this.productGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.FieldName = "Picture";
            gridViewImageColumn1.HeaderText = "Picture";
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.MinWidth = 6;
            gridViewImageColumn1.Name = "Picture";
            gridViewImageColumn1.Width = 103;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.MinWidth = 6;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 105;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Other";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.MinWidth = 6;
            gridViewTextBoxColumn2.Name = "Other";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 109;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "InsertBy";
            gridViewTextBoxColumn3.HeaderText = "Insert By";
            gridViewTextBoxColumn3.MinWidth = 6;
            gridViewTextBoxColumn3.Name = "InsertBy";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 60;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "InsertDate";
            gridViewTextBoxColumn4.HeaderText = "Insert Date";
            gridViewTextBoxColumn4.MinWidth = 6;
            gridViewTextBoxColumn4.Name = "InsertDate";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 85;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "LUN";
            gridViewTextBoxColumn5.HeaderText = "LUN";
            gridViewTextBoxColumn5.MinWidth = 6;
            gridViewTextBoxColumn5.Name = "LUN";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 46;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "LUB";
            gridViewTextBoxColumn6.HeaderText = "LUB";
            gridViewTextBoxColumn6.MinWidth = 6;
            gridViewTextBoxColumn6.Name = "LUB";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 43;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "LUD";
            gridViewTextBoxColumn7.HeaderText = "LUD";
            gridViewTextBoxColumn7.MinWidth = 6;
            gridViewTextBoxColumn7.Name = "LUD";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 76;
            this.productGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewImageColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.productGridView.MasterTemplate.EnablePaging = true;
            this.productGridView.MasterTemplate.PageSize = 10;
            this.productGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.productGridView.Name = "productGridView";
            this.productGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productGridView.Size = new System.Drawing.Size(675, 795);
            this.productGridView.TabIndex = 0;
            this.productGridView.ThemeName = "MaterialBlueGrey";
            this.productGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellDoubleClick);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.productGridView);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(675, 795);
            this.radPanel2.TabIndex = 3;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPanel5);
            this.radPanel1.Controls.Add(this.radPanel4);
            this.radPanel1.Controls.Add(this.radPanel3);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel1.Location = new System.Drawing.Point(675, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(332, 795);
            this.radPanel1.TabIndex = 2;
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.lblID);
            this.radPanel5.Controls.Add(this.btnRemove);
            this.radPanel5.Controls.Add(this.btnAdd);
            this.radPanel5.Controls.Add(this.productPictureBox);
            this.radPanel5.Controls.Add(this.label2);
            this.radPanel5.Controls.Add(this.txtDescription);
            this.radPanel5.Controls.Add(this.lblUserName);
            this.radPanel5.Controls.Add(this.txtName);
            this.radPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel5.Location = new System.Drawing.Point(0, 52);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(332, 540);
            this.radPanel5.TabIndex = 2;
            this.radPanel5.ThemeName = "MaterialBlueGrey";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(239, 505);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 22);
            this.lblID.TabIndex = 10;
            this.lblID.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemove.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnRemove.Image = global::PVCWindowsStudio.Properties.Resources.minus__2_1;
            this.btnRemove.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.Location = new System.Drawing.Point(280, 207);
            this.btnRemove.Name = "btnRemove";
            // 
            // 
            // 
            this.btnRemove.RootElement.EnableFocusBorderAnimation = false;
            this.btnRemove.Size = new System.Drawing.Size(40, 36);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "radButton2";
            this.btnRemove.ThemeName = "MaterialBlueGrey";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnAdd.Image = global::PVCWindowsStudio.Properties.Resources.plus__4_1;
            this.btnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(280, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "radButton1";
            this.btnAdd.ThemeName = "MaterialBlueGrey";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(15, 0);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.ShowBorder = true;
            this.productPictureBox.Size = new System.Drawing.Size(259, 245);
            this.productPictureBox.SvgImageXml = null;
            this.productPictureBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 386);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            // 
            // 
            // 
            this.txtDescription.RootElement.StretchVertically = true;
            this.txtDescription.Size = new System.Drawing.Size(223, 94);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtDescription, null);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(11, 277);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Product Name";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.btnClear);
            this.radPanel4.Controls.Add(this.btnDelete);
            this.radPanel4.Controls.Add(this.btnUpdate);
            this.radPanel4.Controls.Add(this.btnSave);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel4.Location = new System.Drawing.Point(0, 592);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(332, 203);
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
            this.btnClear.Size = new System.Drawing.Size(312, 40);
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
            this.btnDelete.Size = new System.Drawing.Size(312, 40);
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
            this.btnUpdate.Size = new System.Drawing.Size(312, 40);
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
            this.btnSave.Size = new System.Drawing.Size(312, 40);
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
            this.radPanel3.Size = new System.Drawing.Size(332, 52);
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
            this.label1.Size = new System.Drawing.Size(332, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 795);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ProductsForm";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            this.radPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView productGridView;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadPictureBox productPictureBox;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private System.Windows.Forms.Label lblUserName;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnRemove;
        private Telerik.WinControls.UI.RadValidationProvider radValidationProvider1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private System.Windows.Forms.Label lblID;
    }
}
