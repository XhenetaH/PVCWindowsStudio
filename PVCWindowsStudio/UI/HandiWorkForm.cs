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
    public partial class HandiWorkForm : Telerik.WinControls.UI.RadForm
    {
        private readonly HandiWorkBLL handiBll;
        private HandiWork handi;
        public HandiWorkForm()
        {
            handiBll = new HandiWorkBLL();
            handi = new HandiWork();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtMaxHeight.Text) && String.IsNullOrEmpty(txtMinHeight.Text)&& String.IsNullOrEmpty(txtMaxWidth.Text) && String.IsNullOrEmpty(txtMinWidth.Text))
            {
                this.radValidationProvider1.Validate(txtMaxHeight);
                this.radValidationProvider1.Validate(txtMinHeight);
                this.radValidationProvider1.Validate(txtMaxWidth);
                this.radValidationProvider1.Validate(txtMinWidth);
            }
            else
            {
                handi.MaxHeight = int.Parse(txtMaxHeight.Text);
                handi.MinHeight = int.Parse(txtMinHeight.Text);
                handi.MaxWidth = int.Parse(txtMaxWidth.Text);
                handi.MinWidth = int.Parse(txtMinWidth.Text);
                handi.Price = Convert.ToDecimal(txtPrice.Text);

                if (handiBll.Insert(handi))
                {
                    MessageBox.Show("HandiWork inserted successfully!");
                    handiBll.Insert(handi);
                    InitiateData();
                    Clear();
                }
                else MessageBox.Show("Something went wrong!");

            }
        }

        private void InitiateData()
        {
            handworkGridView1.DataSource = handiBll.GetAll();
        }

        private void HandiWorkForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (String.IsNullOrEmpty(txtMaxHeight.Text) && String.IsNullOrEmpty(txtMinHeight.Text) && String.IsNullOrEmpty(txtMaxWidth.Text) && String.IsNullOrEmpty(txtMinWidth.Text))
                {
                    this.radValidationProvider1.Validate(txtMaxHeight);
                    this.radValidationProvider1.Validate(txtMinHeight);
                    this.radValidationProvider1.Validate(txtMaxWidth);
                    this.radValidationProvider1.Validate(txtMinWidth);
                }
                else
                {
                    handi.HandiWorkID = int.Parse(lblID.Text);
                    handi.MaxHeight = int.Parse(txtMaxHeight.Text);
                    handi.MinHeight = int.Parse(txtMinHeight.Text);
                    handi.MaxWidth = int.Parse(txtMaxWidth.Text);
                    handi.MinWidth = int.Parse(txtMinWidth.Text);
                    handi.Price = Convert.ToDecimal(txtPrice.Text);

                    if (handiBll.Update(handi))
                    {
                        MessageBox.Show("HandiWork updated successfully!");
                        handiBll.Update(handi);
                        InitiateData();
                        Clear();

                    }
                    else MessageBox.Show("Something went wrong!");

                }
            }
            else MessageBox.Show("Please select a HandiWork item!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (handiBll.Delete(int.Parse(lblID.Text)))
                    {
                        MessageBox.Show("HandiWork item is deleted successfully!");
                        InitiateData();
                        Clear();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
            }
            else MessageBox.Show("Please select a HandiWork item!");
        }
        private void Clear()
        {
            txtPrice.Text = "";
            txtMaxHeight.Text = "";
            txtMinHeight.Text = "";
            txtMaxWidth.Text = "";
            txtMinWidth.Text = "";
            lblID.Text = "";
        }
        private void handworkGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.radValidationProvider1.ClearErrorStatus();
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                handi = (HandiWork)handworkGridView1.Rows[rowindex].DataBoundItem;
                if (handi != null)
                {
                    lblID.Text = handi.HandiWorkID.ToString();
                    txtMaxWidth.Text = handi.MaxWidth.ToString();
                    txtMinWidth.Text = handi.MinWidth.ToString();
                    txtMaxHeight.Text = handi.MaxHeight.ToString();
                    txtMinHeight.Text = handi.MinHeight.ToString();
                    txtPrice.Text = handi.Price.ToString();
                }
            }
        }
    }
}
