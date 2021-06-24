namespace PVCWindowsStudio.UI
{
    partial class HandiWorkForm
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
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            Telerik.WinControls.UI.RadValidationRule radValidationRule2 = new Telerik.WinControls.UI.RadValidationRule();
            Telerik.WinControls.UI.RadValidationRule radValidationRule3 = new Telerik.WinControls.UI.RadValidationRule();
            Telerik.WinControls.UI.RadValidationRule radValidationRule4 = new Telerik.WinControls.UI.RadValidationRule();
            Telerik.WinControls.UI.RadValidationRule radValidationRule5 = new Telerik.WinControls.UI.RadValidationRule();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtMinHeight = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtMaxHeight = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtMinWidth = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtMaxWidth = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtPricee = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radValidationProvider1 = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.radPanel6 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.handworkGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPricee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel6)).BeginInit();
            this.radPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.handworkGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handworkGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMinHeight
            // 
            this.txtMinHeight.Location = new System.Drawing.Point(30, 313);
            this.txtMinHeight.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtMinHeight.Name = "txtMinHeight";
            this.txtMinHeight.Size = new System.Drawing.Size(262, 41);
            this.txtMinHeight.TabIndex = 17;
            this.txtMinHeight.TabStop = false;
            this.txtMinHeight.Text = "0";
            this.txtMinHeight.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMinHeight.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtMinHeight, radValidationRule1);
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Location = new System.Drawing.Point(30, 234);
            this.txtMaxHeight.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(262, 41);
            this.txtMaxHeight.TabIndex = 14;
            this.txtMaxHeight.TabStop = false;
            this.txtMaxHeight.Text = "0";
            this.txtMaxHeight.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMaxHeight.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtMaxHeight, radValidationRule2);
            // 
            // txtMinWidth
            // 
            this.txtMinWidth.Location = new System.Drawing.Point(30, 148);
            this.txtMinWidth.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtMinWidth.Name = "txtMinWidth";
            this.txtMinWidth.Size = new System.Drawing.Size(262, 41);
            this.txtMinWidth.TabIndex = 15;
            this.txtMinWidth.TabStop = false;
            this.txtMinWidth.Text = "0";
            this.txtMinWidth.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMinWidth.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtMinWidth, radValidationRule3);
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Location = new System.Drawing.Point(30, 76);
            this.txtMaxWidth.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(262, 41);
            this.txtMaxWidth.TabIndex = 16;
            this.txtMaxWidth.TabStop = false;
            this.txtMaxWidth.Text = "0";
            this.txtMaxWidth.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMaxWidth.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtMaxWidth, radValidationRule4);
            // 
            // txtPricee
            // 
            this.txtPricee.Culture = new System.Globalization.CultureInfo("eu");
            this.txtPricee.Location = new System.Drawing.Point(34, 385);
            this.txtPricee.Mask = "^(?!0\\.00)[1-9]\\d{0,2}(,\\d{3})*(\\.\\d\\d)?$";
            this.txtPricee.MaskType = Telerik.WinControls.UI.MaskType.Regex;
            this.txtPricee.Name = "txtPricee";
            this.txtPricee.Size = new System.Drawing.Size(258, 41);
            this.txtPricee.TabIndex = 18;
            this.txtPricee.TabStop = false;
            this.txtPricee.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtPricee, radValidationRule5);
            // 
            // radValidationProvider1
            // 
            this.radValidationProvider1.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.txtMinHeight);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotEqualTo;
            radValidationRule1.ToolTipText = "Minimum Height can\'t be empty!";
            radValidationRule1.Value = 0;
            radValidationRule2.Controls.Add(this.txtMaxHeight);
            radValidationRule2.Operator = Telerik.WinControls.Data.FilterOperator.IsNotEqualTo;
            radValidationRule2.ToolTipText = "Maximum Height can\'t be empty!";
            radValidationRule2.Value = 0;
            radValidationRule3.Controls.Add(this.txtMinWidth);
            radValidationRule3.Operator = Telerik.WinControls.Data.FilterOperator.IsNotEqualTo;
            radValidationRule3.ToolTipText = "Minimum Width can\'t be empty!";
            radValidationRule3.Value = 0;
            radValidationRule4.Controls.Add(this.txtMaxWidth);
            radValidationRule4.Operator = Telerik.WinControls.Data.FilterOperator.IsNotEqualTo;
            radValidationRule4.ToolTipText = "Maximum Width can\'t be empty!";
            radValidationRule4.Value = 0;
            radValidationRule5.Controls.Add(this.txtPricee);
            radValidationRule5.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule5.PropertyName = "Value";
            radValidationRule5.ToolTipText = "Price can\'t be empty!";
            radValidationRule5.Value = "";
            this.radValidationProvider1.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1,
            radValidationRule2,
            radValidationRule3,
            radValidationRule4,
            radValidationRule5});
            // 
            // radPanel6
            // 
            this.radPanel6.Controls.Add(this.radPanel2);
            this.radPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel6.Location = new System.Drawing.Point(585, 0);
            this.radPanel6.Name = "radPanel6";
            this.radPanel6.Size = new System.Drawing.Size(323, 688);
            this.radPanel6.TabIndex = 10;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radPanel5);
            this.radPanel2.Controls.Add(this.radPanel4);
            this.radPanel2.Controls.Add(this.radPanel3);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(323, 688);
            this.radPanel2.TabIndex = 9;
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.txtPricee);
            this.radPanel5.Controls.Add(this.txtMinHeight);
            this.radPanel5.Controls.Add(this.txtMaxWidth);
            this.radPanel5.Controls.Add(this.txtMinWidth);
            this.radPanel5.Controls.Add(this.txtMaxHeight);
            this.radPanel5.Controls.Add(this.label5);
            this.radPanel5.Controls.Add(this.label4);
            this.radPanel5.Controls.Add(this.label3);
            this.radPanel5.Controls.Add(this.label2);
            this.radPanel5.Controls.Add(this.lblID);
            this.radPanel5.Controls.Add(this.lblUserName);
            this.radPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel5.Location = new System.Drawing.Point(0, 52);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(323, 474);
            this.radPanel5.TabIndex = 2;
            this.radPanel5.ThemeName = "MaterialBlueGrey";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Minimum Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maximum Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum Width";
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
            this.lblUserName.Location = new System.Drawing.Point(30, 41);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(129, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Maximum Width";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.btnClear);
            this.radPanel4.Controls.Add(this.btnDelete);
            this.radPanel4.Controls.Add(this.btnUpdate);
            this.radPanel4.Controls.Add(this.btnSave);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel4.Location = new System.Drawing.Point(0, 526);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(323, 162);
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
            this.btnClear.Size = new System.Drawing.Size(302, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.ThemeName = "MaterialBlueGrey";
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
            this.btnDelete.Size = new System.Drawing.Size(302, 40);
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
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnUpdate.Image = global::PVCWindowsStudio.Properties.Resources.pencil;
            this.btnUpdate.Location = new System.Drawing.Point(8, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(302, 40);
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
            this.btnSave.Size = new System.Drawing.Size(303, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.ThemeName = "MaterialBlueGrey";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
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
            this.radPanel3.Size = new System.Drawing.Size(323, 52);
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
            this.label1.Size = new System.Drawing.Size(323, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "HandiWork Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // handworkGridView1
            // 
            this.handworkGridView1.BackColor = System.Drawing.Color.White;
            this.handworkGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.handworkGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.handworkGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.handworkGridView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.handworkGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.handworkGridView1.Location = new System.Drawing.Point(0, 0);
            this.handworkGridView1.Margin = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.handworkGridView1.MasterTemplate.AllowAddNewRow = false;
            this.handworkGridView1.MasterTemplate.AllowDeleteRow = false;
            this.handworkGridView1.MasterTemplate.AllowEditRow = false;
            this.handworkGridView1.MasterTemplate.AllowSearchRow = true;
            this.handworkGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "MaxWidth";
            gridViewTextBoxColumn1.HeaderText = "Maximum Width";
            gridViewTextBoxColumn1.MinWidth = 6;
            gridViewTextBoxColumn1.Name = "MaxWidth";
            gridViewTextBoxColumn1.Width = 106;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "MinWidth";
            gridViewTextBoxColumn2.HeaderText = "Minimum Width";
            gridViewTextBoxColumn2.MinWidth = 6;
            gridViewTextBoxColumn2.Name = "MinWidth";
            gridViewTextBoxColumn2.Width = 103;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "MinHeight";
            gridViewTextBoxColumn3.HeaderText = "Minimum Height";
            gridViewTextBoxColumn3.MinWidth = 6;
            gridViewTextBoxColumn3.Name = "MinHeight";
            gridViewTextBoxColumn3.Width = 107;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "MaxHeight";
            gridViewTextBoxColumn4.HeaderText = "Maximum Height";
            gridViewTextBoxColumn4.MinWidth = 6;
            gridViewTextBoxColumn4.Name = "MaxHeight";
            gridViewTextBoxColumn4.Width = 109;
            gridViewTextBoxColumn5.DataType = typeof(decimal);
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Price";
            gridViewTextBoxColumn5.HeaderText = "Price";
            gridViewTextBoxColumn5.MinWidth = 6;
            gridViewTextBoxColumn5.Name = "Price";
            gridViewTextBoxColumn5.Width = 112;
            this.handworkGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.handworkGridView1.MasterTemplate.EnablePaging = true;
            this.handworkGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.handworkGridView1.Name = "handworkGridView1";
            this.handworkGridView1.ReadOnly = true;
            this.handworkGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.handworkGridView1.Size = new System.Drawing.Size(585, 688);
            this.handworkGridView1.TabIndex = 0;
            this.handworkGridView1.ThemeName = "MaterialBlueGrey";
            this.handworkGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.handworkGridView1_CellClick);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.handworkGridView1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(585, 688);
            this.radPanel1.TabIndex = 11;
            // 
            // HandiWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 688);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HandiWorkForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "HandiWorkForm";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.HandiWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMinHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPricee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel6)).EndInit();
            this.radPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.handworkGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handworkGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadValidationProvider radValidationProvider1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel6;
        private Telerik.WinControls.UI.RadGridView handworkGridView1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUserName;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadMaskedEditBox txtMaxHeight;
        private Telerik.WinControls.UI.RadMaskedEditBox txtMinWidth;
        private Telerik.WinControls.UI.RadMaskedEditBox txtMaxWidth;
        private Telerik.WinControls.UI.RadMaskedEditBox txtMinHeight;
        private Telerik.WinControls.UI.RadMaskedEditBox txtPricee;
    }
}
