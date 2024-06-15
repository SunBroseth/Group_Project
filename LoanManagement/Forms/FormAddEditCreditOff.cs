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
    public partial class FormAddEditCreditOff : Form
    {
        bool newofficer;
        CreditOfficer _officer;
        public FormAddEditCreditOff(CreditOfficer officer)
        {
            InitializeComponent();
            if (officer == null)
            {
                this._officer = new CreditOfficer();
                
                lblTitle.Text = "New Officer";
                this.newofficer = true;
                txtOfficername.Focus();
               
            }
            else
            {
                this._officer = officer;
                this.newofficer = false;
                lblTitle.Text = "Edit Officer";
                InitializeData();
                txtOfficername.Focus();
               
            }

        }
        void InitializeData()
        {
            txtOfficername.Text = _officer.CreditOfficerName;
            cboSex.Text = _officer.Sex;
            dtDOB.Value = _officer.DOB;
            txtPOB.Text = _officer.POB;
            txtPhone.Text = _officer.Phone;
            txtEmail.Text = _officer.Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _officer.CreditOfficerName = txtOfficername.Text;
            _officer.Sex = cboSex.Text.Trim();
            _officer.POB = txtPOB.Text.Trim();
            _officer.DOB = dtDOB.Value;
            _officer.Phone = txtPhone.Text.Trim();
            _officer.Email = txtEmail.Text.Trim();
          

            if (txtOfficername.Text == "")
            {
                MessageBox.Show("Data required!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (this.DialogResult == DialogResult.OK)
                    return;

            }
            else
            {
                if (newofficer)
                {
                    CreditOfficerService.Add(_officer);

                }
                else
                {
                    CreditOfficerService.Update(_officer);

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
