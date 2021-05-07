using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PVCWindowsStudio.UI
{
    public partial class ProfilesForm : Telerik.WinControls.UI.RadForm
    {
        private Profiles profile;
        private ProfileBLL profileBll;
        public ProfilesForm()
        {
            profile = new Profiles();
            profileBll = new ProfileBLL();
            InitializeComponent();
        }

        private void ProfilesForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void InitiateData()
        {
            var list = profileBll.GetAll();
            profileGridView.DataSource = list;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            profile.Name = txtName.Text;
            profile.Other = txtDescription.Text;
            profile.Color = txtColor.Text;
            profile.InsertBy = 1;
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtColor.Text))
            {
                profileBll.Insert(profile);               
            }
            this.radValidationProvider1.Validate(txtName);
            this.radValidationProvider1.Validate(txtColor);
            Clear();
            InitiateData();
        }
        private void Clear()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtColor.Text = "";
            lblID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            profile.Name = txtName.Text;
            profile.Other = txtDescription.Text;
            profile.Color = txtColor.Text;
            profile.LUB = 1;
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtDescription.Text))
            {
                profileBll.Update(profile);
            }
            this.radValidationProvider1.Validate(txtName);
            this.radValidationProvider1.Validate(txtColor);
            Clear();
            InitiateData();
        }

        private void profileGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            profile = (Profiles)profileGridView.Rows[rowindex].DataBoundItem;
            if (profile != null)
            {
                lblID.Text = profile.ProfileID.ToString();
                txtName.Text = profile.Name;
                txtDescription.Text = profile.Other;
                txtColor.Text = profile.Color;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    profileBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
