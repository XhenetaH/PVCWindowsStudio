using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PVCWindowsStudio.UI
{
    public partial class WindowPanesForm : Telerik.WinControls.UI.RadForm
    {
        private WindowPanes windowpane;
        private WindowPaneBLL windowpaneBll;

        public WindowPanesForm()
        {
            windowpane = new WindowPanes();
            windowpaneBll = new WindowPaneBLL();
            InitializeComponent();
        }

        private void WindowPanesForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void InitiateData()
        {
            var list = windowpaneBll.GetAll();
            windowpaneGridView.DataSource = list;

            windowpaneGridView.Columns[0].IsVisible = false;
            windowpaneGridView.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            windowpaneGridView.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            windowpaneGridView.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            windowpaneGridView.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
            windowpaneGridView.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
            windowpaneGridView.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;
            windowpaneGridView.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;
            windowpaneGridView.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            windowpane.Name = txtName.Text;
            windowpane.Other = txtDescription.Text;
            windowpane.InsertBy = 1;
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                windowpaneBll.Insert(windowpane);
                InitiateData();

            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
        }
        private void Clear()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            lblID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            windowpane.Name = txtName.Text;
            windowpane.Other = txtDescription.Text;
            windowpane.LUB = 1;
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                windowpaneBll.Update(windowpane);
                InitiateData();
            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    windowpaneBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void windowpaneGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            windowpane = (WindowPanes)windowpaneGridView.Rows[rowindex].DataBoundItem;
            if (windowpane != null)
            {
                lblID.Text = windowpane.WindowPaneID.ToString();
                txtName.Text = windowpane.Name;
                txtDescription.Text = windowpane.Other;
            }
        }
    }
}
