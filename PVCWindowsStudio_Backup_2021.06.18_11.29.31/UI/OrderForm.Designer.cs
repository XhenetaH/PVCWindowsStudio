namespace PVCWindowsStudio.UI
{
    partial class OrderForm
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
            Telerik.WinControls.UI.RadValidationRule radValidationRule5 = new Telerik.WinControls.UI.RadValidationRule();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition9 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn35 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn36 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn37 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn38 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn39 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn40 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition10 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radValidationProvider1 = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.txtComment = new Telerik.WinControls.UI.RadTextBox();
            this.clientMultiComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtDiscount = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.lblUserName = new System.Windows.Forms.Label();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.orderGridView = new Telerik.WinControls.UI.RadGridView();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.lblClientID = new System.Windows.Forms.Label();
            this.discountCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMultiComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMultiComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMultiComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radValidationProvider1
            // 
            this.radValidationProvider1.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule5.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule5.ToolTipText = "Name can\'t be empty!";
            radValidationRule5.Value = "";
            this.radValidationProvider1.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule5});
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(30, 328);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            // 
            // 
            // 
            this.txtComment.RootElement.StretchVertically = true;
            this.txtComment.Size = new System.Drawing.Size(312, 85);
            this.txtComment.TabIndex = 5;
            this.txtComment.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtComment, null);
            // 
            // clientMultiComboBox
            // 
            this.clientMultiComboBox.AutoFilter = true;
            this.clientMultiComboBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // clientMultiComboBox.NestedRadGridView
            // 
            this.clientMultiComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.clientMultiComboBox.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientMultiComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clientMultiComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.clientMultiComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.clientMultiComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.clientMultiComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.clientMultiComboBox.EditorControl.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.clientMultiComboBox.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.clientMultiComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn33.FieldName = "ClientID";
            gridViewTextBoxColumn33.HeaderText = "ClientID";
            gridViewTextBoxColumn33.Name = "ClientID";
            gridViewTextBoxColumn33.Width = 43;
            gridViewTextBoxColumn34.FieldName = "FullName";
            gridViewTextBoxColumn34.HeaderText = "Full Name";
            gridViewTextBoxColumn34.Name = "Name";
            gridViewTextBoxColumn34.Width = 237;
            this.clientMultiComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn33,
            gridViewTextBoxColumn34});
            this.clientMultiComboBox.EditorControl.MasterTemplate.EnableFiltering = true;
            this.clientMultiComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.clientMultiComboBox.EditorControl.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.None;
            this.clientMultiComboBox.EditorControl.MasterTemplate.ShowColumnHeaders = false;
            this.clientMultiComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.clientMultiComboBox.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition9;
            this.clientMultiComboBox.EditorControl.Name = "NestedRadGridView";
            this.clientMultiComboBox.EditorControl.ReadOnly = true;
            this.clientMultiComboBox.EditorControl.ShowGroupPanel = false;
            this.clientMultiComboBox.EditorControl.Size = new System.Drawing.Size(300, 187);
            this.clientMultiComboBox.EditorControl.TabIndex = 0;
            this.clientMultiComboBox.EditorControl.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radMultiColumnComboBox1_EditorControl_CellClick);
            this.clientMultiComboBox.Location = new System.Drawing.Point(30, 70);
            this.clientMultiComboBox.Name = "clientMultiComboBox";
            this.clientMultiComboBox.Size = new System.Drawing.Size(312, 41);
            this.clientMultiComboBox.TabIndex = 39;
            this.clientMultiComboBox.TabStop = false;
            this.clientMultiComboBox.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.clientMultiComboBox, null);
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.CalendarSize = new System.Drawing.Size(290, 320);
            this.radDateTimePicker1.Location = new System.Drawing.Point(30, 153);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(312, 41);
            this.radDateTimePicker1.TabIndex = 41;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "Friday, June 18, 2021";
            this.radDateTimePicker1.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.radDateTimePicker1, null);
            this.radDateTimePicker1.Value = new System.DateTime(2021, 6, 18, 15, 14, 13, 181);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(30, 231);
            this.txtDiscount.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(266, 41);
            this.txtDiscount.TabIndex = 43;
            this.txtDiscount.TabStop = false;
            this.txtDiscount.Text = "0";
            this.txtDiscount.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtDiscount, null);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.radPanel3.Size = new System.Drawing.Size(354, 52);
            this.radPanel3.TabIndex = 2;
            this.radPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanel3.ThemeName = "MaterialBlueGrey";
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
            this.btnUpdate.Size = new System.Drawing.Size(334, 40);
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
            this.btnSave.Image = global::PVCWindowsStudio.Properties.Resources.print;
            this.btnSave.Location = new System.Drawing.Point(8, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(334, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "PRINT";
            this.btnSave.ThemeName = "MaterialBlueGrey";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.print;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "PRINT";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 386);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 22);
            this.lblID.TabIndex = 7;
            this.lblID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comment";
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
            this.btnClear.Size = new System.Drawing.Size(334, 40);
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
            this.btnDelete.Size = new System.Drawing.Size(334, 40);
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
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(26, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(51, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Client";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.orderGridView);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(596, 886);
            this.radPanel2.TabIndex = 3;
            // 
            // orderGridView
            // 
            this.orderGridView.BackColor = System.Drawing.Color.White;
            this.orderGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.orderGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.orderGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.orderGridView.Location = new System.Drawing.Point(0, 0);
            this.orderGridView.Margin = new System.Windows.Forms.Padding(8);
            // 
            // 
            // 
            this.orderGridView.MasterTemplate.AllowAddNewRow = false;
            this.orderGridView.MasterTemplate.AllowDeleteRow = false;
            this.orderGridView.MasterTemplate.AllowEditRow = false;
            this.orderGridView.MasterTemplate.AllowSearchRow = true;
            this.orderGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn35.EnableExpressionEditor = false;
            gridViewTextBoxColumn35.FieldName = "OrderID";
            gridViewTextBoxColumn35.HeaderText = "OrderID";
            gridViewTextBoxColumn35.MinWidth = 6;
            gridViewTextBoxColumn35.Name = "OrderID";
            gridViewTextBoxColumn35.Width = 88;
            gridViewTextBoxColumn36.EnableExpressionEditor = false;
            gridViewTextBoxColumn36.FieldName = "Clients.FullName";
            gridViewTextBoxColumn36.HeaderText = "Client";
            gridViewTextBoxColumn36.MinWidth = 6;
            gridViewTextBoxColumn36.Name = "Client";
            gridViewTextBoxColumn36.Width = 102;
            gridViewTextBoxColumn37.EnableExpressionEditor = false;
            gridViewTextBoxColumn37.FieldName = "FullDiscount";
            gridViewTextBoxColumn37.HeaderText = "Discount";
            gridViewTextBoxColumn37.MinWidth = 6;
            gridViewTextBoxColumn37.Name = "Discount";
            gridViewTextBoxColumn37.Width = 74;
            gridViewTextBoxColumn38.DataType = typeof(decimal);
            gridViewTextBoxColumn38.EnableExpressionEditor = false;
            gridViewTextBoxColumn38.FieldName = "TotalPrice";
            gridViewTextBoxColumn38.HeaderText = "TotalPrice";
            gridViewTextBoxColumn38.MinWidth = 6;
            gridViewTextBoxColumn38.Name = "TotalPrice";
            gridViewTextBoxColumn38.Width = 74;
            gridViewTextBoxColumn39.EnableExpressionEditor = false;
            gridViewTextBoxColumn39.FieldName = "Date";
            gridViewTextBoxColumn39.HeaderText = "Date";
            gridViewTextBoxColumn39.MinWidth = 6;
            gridViewTextBoxColumn39.Name = "Date";
            gridViewTextBoxColumn39.Width = 88;
            gridViewTextBoxColumn40.EnableExpressionEditor = false;
            gridViewTextBoxColumn40.FieldName = "Comment";
            gridViewTextBoxColumn40.HeaderText = "Comment";
            gridViewTextBoxColumn40.MinWidth = 6;
            gridViewTextBoxColumn40.Name = "Comment";
            gridViewTextBoxColumn40.Width = 122;
            this.orderGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn35,
            gridViewTextBoxColumn36,
            gridViewTextBoxColumn37,
            gridViewTextBoxColumn38,
            gridViewTextBoxColumn39,
            gridViewTextBoxColumn40});
            this.orderGridView.MasterTemplate.EnablePaging = true;
            this.orderGridView.MasterTemplate.ViewDefinition = tableViewDefinition10;
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderGridView.Size = new System.Drawing.Size(596, 886);
            this.orderGridView.TabIndex = 0;
            this.orderGridView.ThemeName = "MaterialBlueGrey";
            this.orderGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellClick);
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.lblClientID);
            this.radPanel5.Controls.Add(this.discountCmb);
            this.radPanel5.Controls.Add(this.txtDiscount);
            this.radPanel5.Controls.Add(this.label4);
            this.radPanel5.Controls.Add(this.radDateTimePicker1);
            this.radPanel5.Controls.Add(this.label3);
            this.radPanel5.Controls.Add(this.clientMultiComboBox);
            this.radPanel5.Controls.Add(this.lblID);
            this.radPanel5.Controls.Add(this.label2);
            this.radPanel5.Controls.Add(this.txtComment);
            this.radPanel5.Controls.Add(this.lblUserName);
            this.radPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel5.Location = new System.Drawing.Point(0, 52);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(354, 631);
            this.radPanel5.TabIndex = 2;
            this.radPanel5.ThemeName = "MaterialBlueGrey";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(129, 302);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(0, 23);
            this.lblClientID.TabIndex = 45;
            this.lblClientID.Visible = false;
            // 
            // discountCmb
            // 
            this.discountCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discountCmb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountCmb.FormattingEnabled = true;
            this.discountCmb.Items.AddRange(new object[] {
            "%",
            "€"});
            this.discountCmb.Location = new System.Drawing.Point(302, 236);
            this.discountCmb.Name = "discountCmb";
            this.discountCmb.Size = new System.Drawing.Size(40, 31);
            this.discountCmb.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Date";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPanel5);
            this.radPanel1.Controls.Add(this.radPanel4);
            this.radPanel1.Controls.Add(this.radPanel3);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel1.Location = new System.Drawing.Point(596, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(354, 886);
            this.radPanel1.TabIndex = 2;
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.btnClear);
            this.radPanel4.Controls.Add(this.btnDelete);
            this.radPanel4.Controls.Add(this.btnUpdate);
            this.radPanel4.Controls.Add(this.btnSave);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel4.Location = new System.Drawing.Point(0, 683);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(354, 203);
            this.radPanel4.TabIndex = 2;
            this.radPanel4.ThemeName = "MaterialBlueGrey";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 886);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "OrderForm";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMultiComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMultiComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMultiComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            this.radPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadValidationProvider radValidationProvider1;
        private Telerik.WinControls.UI.RadTextBox txtComment;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private System.Windows.Forms.Label lblUserName;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadGridView orderGridView;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox clientMultiComboBox;
        private Telerik.WinControls.UI.RadMaskedEditBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox discountCmb;
        private System.Windows.Forms.Label lblClientID;
    }
}
