using LoanManagement.Data.Models;
using LoanManagement.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace LoanManagement.Forms
{
    public partial class FormAddEditCollateral : Form
    {
        CollateralType _collateraltype;
        bool newcollateral;
        bool newcollateraltype;
        Collateral _collateral;
        public FormAddEditCollateral(Collateral collateral,CollateralType collateralType)
        {
            
        
                InitializeComponent();
            if (collateral == null)
            {
                this._collateral = new Collateral();
                this._collateraltype = new CollateralType();
                lblTitle.Text = "New Collateral";
                this.newcollateral = true;
               this.newcollateraltype = true;
                txtOwnerName.Focus();
                cboCollateralType.Focus();
            }
            else
            {
                this._collateral = collateral;
                this._collateraltype = collateralType;
                this.newcollateral = false;
                this.newcollateral = false;
                lblTitle.Text = "Edit Collateral";
                InitializeData();
                txtOwnerName.Focus();
                cboCollateralType.Focus();
            }
        }
        void InitializeData()
        {
            txtOwnerName.Text = _collateral.OwnerName;
            //cboCollateralType.Text = _collateral.CollateralTypeId.ToString();
            cboCollateralType.Text = _collateraltype.CollateralTypeName;
            txtCollateralCode.Text = _collateral.CollateralCode.ToString();
            txtNationalCardNumber.Text = _collateral.OwnerNationalCardNumber.ToString();
            txtCollateralDecsription.Text = _collateral.CollateralDescription;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            _collateral.OwnerName = txtOwnerName.Text.Trim();
            //_collateral.CollateralTypeId = Convert.ToInt32(cboCollateralType.SelectedValue);
            _collateraltype.CollateralTypeName = cboCollateralType.Text;
            _collateral.CollateralCode = txtCollateralCode.Text.Trim();
            _collateral.OwnerNationalCardNumber = txtNationalCardNumber.Text.Trim();
            _collateral.CollateralDescription = txtCollateralDecsription.Text.Trim();


            if (txtOwnerName.Text == "" || cboCollateralType.Text == "")
            {
                MessageBox.Show("Data required!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (this.DialogResult == DialogResult.OK)
                    return;

            }
            else
            {
                if (newcollateral)
                {
                    CollateralService.Add(_collateral);

                }
                else
                {
                    CollateralService.Update(_collateral);

                }

                if (newcollateraltype)
                {
                    CollateralTypeService.Add(_collateraltype);

                }
                else
                {
                    CollateralTypeService.Update(_collateraltype);

                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
