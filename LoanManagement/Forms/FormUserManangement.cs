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

namespace LoanManagement.Forms
{
    public partial class FormUserManangement : Form
    {
        FormMain frmmain;
        DataTable dtUsers;
        DataTable dtUserPermission;
        public FormUserManangement(FormMain frmmain)
        {
            this.frmmain = frmmain;
            InitializeComponent();
            InitializeData();
        }

        void InitializeData()
        {
            dtUsers = AppUserService.GetAll();
            dgUsers.DataSource = dtUsers;
            dgUsers.Columns[0].Visible = false;
            dgUsers.Columns[1].Visible = false;
            dgUsers.Columns[2].Visible = true;
            dgUsers.Columns[2].HeaderText = "Username";
            dgUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgUsers.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            
            dgUsers.Columns[3].Visible = false;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormAddEditUserMgt formAddEdit = new FormAddEditUserMgt(null);
            if (formAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count > 0)
            {
                int userid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value);
                AppUser user = AppUserService.Get(userid);
                FormAddEditUserMgt formAddEdit = new FormAddEditUserMgt(user);
                if (formAddEdit.ShowDialog() == DialogResult.OK)
                {
                    InitializeData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count <= 0)
                return;
            DialogResult confirm = MessageBox.Show("Are yor sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;
            int userid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells[0].Value);
            AppUserService.Delete(userid);
            MessageBox.Show("User has deleted succesfully");
            InitializeData();
        }

        private void btnSelectAll_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = true;
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void btnApplyPermission_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells[0].Value);
            AppUserPermissionService.Delete(userid);

            foreach (Control control in pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox permission = (CheckBox)control;
                    if (permission.Checked)
                    {
                        AppUserPermission userpermission = new AppUserPermission();
                        userpermission.AppUserId = userid;
                        
                        userpermission.UserPermission = permission.Name;
                        AppUserPermissionService.Add(userpermission);
                    }
                }
            }
            MessageBox.Show("Saved Succefully");
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count <= 0)
                return;

            int userid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells[0].Value);
           
            dtUserPermission = AppUserPermissionService.Get(userid);
            foreach (Control control in pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
            foreach (DataRow row in dtUserPermission.Rows)
            {
                ((CheckBox)pnPermission.Controls[row["UserPermission"].ToString()]).Checked = true;
            }
        }
    }
}
