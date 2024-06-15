using LoanManagement.Data.Models;
using LoanManagement.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagement.Forms
{
    public partial class FormCollateral : Form
    {
        DataTable dtCollateralType;
        DataTable dtofficer;
        FormMain frmmain;
        public FormCollateral(FormMain formMain)
        {
            this.frmmain = formMain;
            InitializeComponent();
            InitializeData();
            getcollateralType();
        }

        private void InitializeData()
        {
            dtofficer = CollateralService.GetAll();

            dgOwners.DataSource = dtofficer;


            dgOwners.Columns[0].Visible = false;


            dgOwners.Columns[1].Visible = false;
            dgOwners.Columns[2].Visible = false;
            //dgOwners.Columns[3].HeaderText = "Owner Name";
            //dgOwners.Columns[3].Width = 200;
            //dgOwners.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgOwners.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgOwners.Columns[3].Visible = false;

            
            dgOwners.Columns[4].Visible = false;
            dgOwners.Columns[5].Visible = false;
            dgOwners.Columns[6].Visible = false;
           

        }
        private void getcollateralType()
        {
            dtCollateralType = CollateralTypeService.GetAll();
            dgCollateralType.DataSource = dtCollateralType;
            dgCollateralType.Columns[0].Visible = false;

            dgCollateralType.Columns[1].HeaderText = "Collateral Type";
            dgOwners.Columns[1].Width = 200;
            dgOwners.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgOwners.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCollateralType.Columns[1].Visible = true;
            
            


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormAddEditCollateral formAddEdit = new FormAddEditCollateral(null,null);
            if (formAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
                getcollateralType();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SynchronizeSelection(dgCollateralType, dgOwners);
            if (dgOwners.SelectedRows.Count > 0 && dgCollateralType.SelectedRows.Count > 0)
            {


                int collateraltypeid = Convert.ToInt32(dgCollateralType.SelectedRows[0].Cells["CollateralTypeId"].Value.ToString());
                int collateralid = Convert.ToInt32(dgOwners.SelectedRows[0].Cells["CollateralId"].Value.ToString());
                Collateral collateral = CollateralService.Get(collateralid);
                CollateralType collateraltype = CollateralTypeService.Get(collateraltypeid);
                if (collateral == null && collateraltype == null)
                {
                    MessageBox.Show("Cannot find collateral");
                }
                else
                {
                    FormAddEditCollateral formAddEdit = new FormAddEditCollateral(collateral,collateraltype);
                    if (formAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitializeData();
                        getcollateralType();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SynchronizeSelection(dgCollateralType, dgOwners);
            DialogResult confirm = MessageBox.Show(this, "Confirmation!\nDo you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int collateraltypeidid = Convert.ToInt32(dgCollateralType.SelectedRows[0].Cells["CollateralTypeId"].Value.ToString());
                int collateralid = Convert.ToInt32(dgOwners.SelectedRows[0].Cells["CollateralId"].Value.ToString());
                CollateralService.Delete(collateralid);
                CollateralTypeService.Delete(collateraltypeidid);
                


                MessageBox.Show("Colateral has Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeData();
                getcollateralType();
                txtOwnerName.Clear();
                txtNationalCardNumber.Clear();
                txtCollateralType.Clear();

                txtCode.Clear();
                txtDescription.Clear();

            }
        }

        private void FormCollateral_Load(object sender, EventArgs e)
        {
            dgOwners.SelectionChanged += dgOwners_SelectionChanged;
            dgCollateralType.SelectionChanged += dgCollateralType_SelectionChanged;
            dgOwners.MultiSelect = true;
            dgCollateralType.MultiSelect = true;
            


            DataTable dtPermission = AppUserPermissionService.Get(frmmain.userLogon.AppUserId);
            foreach (DataRow dr in dtPermission.Rows)
            {
                if (dr["UserPermission"].ToString() == "CollateralCreate")
                {
                    btnNew.Visible = true;
                }

                if (dr["UserPermission"].ToString() == "CollateralModify")
                {
                    btnEdit.Visible = true;
                }

                if (dr["UserPermission"].ToString() == "CollateralDelete")
                {
                    btnDelete.Visible = true;
                }
            }
        }


        private void dgOwners_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dgOwners.SelectedRows.Count > 0)
            {

                int collateralid = Convert.ToInt32(dgOwners.SelectedRows[0].Cells["CollateralId"].Value.ToString());
                Collateral collateral = CollateralService.Get(collateralid);

                if (collateral != null)
                {
                    txtOwnerName.Text = collateral.OwnerName;
                    txtCode.Text = collateral.CollateralCode.ToString();
                    txtNationalCardNumber.Text = collateral.OwnerNationalCardNumber.ToString();
                    //txtCollateralType.Text = collateral.CollateralTypeId.ToString();
                    txtDescription.Text = collateral.CollateralDescription;

                }


            }
        }

        private void dgCollateralType_SelectionChanged(object sender, EventArgs e)
        {
            SynchronizeSelection(dgCollateralType, dgOwners);
            if (dgCollateralType.SelectedRows.Count > 0)
            {

                int collateraltypeid = Convert.ToInt32(dgCollateralType.SelectedRows[0].Cells["CollateralTypeId"].Value.ToString());
                CollateralType collateraltype = CollateralTypeService.Get(collateraltypeid);


                if (collateraltype != null)
                {
                    txtCollateralType.Text = collateraltype.CollateralTypeName;
                }


            }
        }

        private void SynchronizeSelection(DataGridView sourceGrid, DataGridView targetGrid)
        {
            // Clear previous selection in the target grid
            targetGrid.ClearSelection();

            // Select rows in the target grid based on the selected rows in the source grid
            foreach (DataGridViewRow selectedRow in sourceGrid.SelectedRows)
            {
                int rowIndex = selectedRow.Index;
                if (rowIndex >= 0 && rowIndex < targetGrid.Rows.Count)
                {
                    targetGrid.Rows[rowIndex].Selected = true;
                }
                //if (selectedRow.Cells[0].Value != null || string.IsNullOrEmpty(selectedRow.Cells[0].Value.ToString()))
                //{
                //    targetGrid.Rows[rowIndex].Selected = true;
                //}
            }
        }
    }
}
