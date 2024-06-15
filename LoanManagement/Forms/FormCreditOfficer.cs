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
    public partial class FormCreditOfficer : Form
    {
        
        DataTable dtofficer;
        FormMain frmmain;
        public FormCreditOfficer(FormMain formMain)
        {
            this.frmmain = formMain;
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            dtofficer = CreditOfficerService.GetAll();

            dgOfficers.DataSource = dtofficer;


            dgOfficers.Columns[0].Visible = false;


            dgOfficers.Columns[1].Visible = false;

            dgOfficers.Columns[2].HeaderText = "Officer Name";
            dgOfficers.Columns[2].Width = 200;
            dgOfficers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgOfficers.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgOfficers.Columns[2].Visible = true;

            dgOfficers.Columns[3].Visible = false;
            dgOfficers.Columns[4].Visible = false;
            dgOfficers.Columns[5].Visible = false;
            dgOfficers.Columns[6].Visible = false;
            dgOfficers.Columns[7].Visible = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormAddEditCreditOff formAddEdit = new FormAddEditCreditOff(null);
            if (formAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgOfficers.SelectedRows.Count > 0)
            {


                
                int officerid = Convert.ToInt32(dgOfficers.SelectedRows[0].Cells["CreditOfficerId"].Value.ToString());
                CreditOfficer officer = CreditOfficerService.Get(officerid);
                if (officer == null)
                {
                    MessageBox.Show("Cannot find officer");
                }
                else
                {
                    FormAddEditCreditOff formAddEdit = new FormAddEditCreditOff(officer);
                    if (formAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitializeData();
                        
                    }
                }

            }
        }



        private void dgCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgOfficers.SelectedRows.Count > 0)
            {

                int officerid = Convert.ToInt32(dgOfficers.SelectedRows[0].Cells["CreditOfficerId"].Value.ToString());
                CreditOfficer officer = CreditOfficerService.Get(officerid);


                if (officer != null)
                {
                    txtCreditOfficerName.Text = officer.CreditOfficerName;
                    txtSex.Text = officer.Sex;
                    txtDOB.Text = officer.DOB.ToString("dd,  MMMM,  yyyy");
                    txtPOB.Text = officer.POB;
                    txtPhone.Text = officer.Phone;
                    txtEmail.Text = officer.Email;

                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(this, "Confirmation!\nDo you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                
                int officerid = Convert.ToInt32(dgOfficers.SelectedRows[0].Cells["CreditOfficerId"].Value.ToString());
                CreditOfficerService.Delete(officerid);


                

                MessageBox.Show("Officer has Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeData();
                
                txtCreditOfficerName.Clear();
                txtDOB.Clear();
                txtPOB.Clear();
                
                txtEmail.Clear();
                txtPhone.Clear();
                
            }
        }

        private void FormCreditOfficer_Load(object sender, EventArgs e)
        {
            DataTable dtPermission = AppUserPermissionService.Get(frmmain.userLogon.AppUserId);
            foreach (DataRow dr in dtPermission.Rows)
            {
                if (dr["UserPermission"].ToString() == "CreditOfficerCreate")
                {
                    btnNew.Visible = true;
                }

                if (dr["UserPermission"].ToString() == "CreditOfficerModify")
                {
                    btnEdit.Visible = true;
                }

                if (dr["UserPermission"].ToString() == "CreditOfficerDelete")
                {
                    btnDelete.Visible = true;
                }
            }
        }
    }

}
