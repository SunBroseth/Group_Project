using LoanManagement.Data.Models;
using LoanManagement.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoanManagement.Forms
{
    public partial class FormCustomer : Form
    {

        DataTable dtAddress;
        DataTable dtCustomer;
        FormMain frmmain;
        public FormCustomer(FormMain frmmain)
        {
            InitializeComponent();
            InitializeData();
            getAddress();
            this.frmmain = frmmain;
        }

        private void InitializeData()
        {
            dtCustomer = CustomerService.GetAll();
          
            dgCustomers.DataSource = dtCustomer;
            
            
            dgCustomers.Columns[0].Visible = false;

            
            dgCustomers.Columns[1].Visible = false;

            dgCustomers.Columns[2].HeaderText = "Customer Name";
            dgCustomers.Columns[2].Width = 200;
            dgCustomers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomers.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomers.Columns[2].Visible = true;

            dgCustomers.Columns[3].Visible = false;
            dgCustomers.Columns[4].Visible = false;
            dgCustomers.Columns[5].Visible = false;
            dgCustomers.Columns[6].Visible = false;
            dgCustomers.Columns[7].Visible = false;
           

            



        }

        private void getAddress()
        {
            dtAddress = AddressService.GetAll();
            dgAddress.DataSource = dtAddress;
            dgAddress.Columns[0].Visible = false;


            dgAddress.Columns[1].Visible = false;
            dgAddress.Columns[2].HeaderText = "Address Name";
            dgAddress.Columns[2].Visible = false;
        }
       

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerAddEdit formAddEdit = new FormCustomerAddEdit(null,null);
            if (formAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
                getAddress();
            }
        }

        private void dgCustomers_SelectionChanged(object sender, EventArgs e)
        {
            SynchronizeSelection(dgCustomers, dgAddress);
            if (dgCustomers.SelectedRows.Count > 0)
            {
               
                int customerid = Convert.ToInt32(dgCustomers.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                Customer customer = CustomerService.Get(customerid);
                
                
                if (customer != null)
                {
                    txtCustomerName.Text = customer.CustomerName;
                    txtSex.Text = customer.Sex;
                    txtDOB.Text = customer.DOB.ToString("dd,  MMMM,  yyyy");
                    txtPOB.Text = customer.POB;
                    txtPhone.Text = customer.Phone;
                    txtEmail.Text = customer.Email;
                    
                }

                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SynchronizeSelection(dgCustomers, dgAddress);
            if (dgCustomers.SelectedRows.Count > 0 && dgAddress.SelectedRows.Count > 0)
            {

                
                int addressid = Convert.ToInt32(dgAddress.SelectedRows[0].Cells["AddressId"].Value.ToString());
                int customerid = Convert.ToInt32(dgCustomers.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                Customer customer = CustomerService.Get(customerid);
                Address address = AddressService.Get(addressid);
                if (customer == null && address == null)
                {
                    MessageBox.Show("Cannot find customer");
                }
                else
                {
                    FormCustomerAddEdit formAddEdit = new FormCustomerAddEdit(customer,address);
                    if (formAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitializeData();
                        getAddress();
                    }
                }
               
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SynchronizeSelection(dgCustomers, dgAddress);
            DialogResult confirm = MessageBox.Show(this, "Confirmation!\nDo you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int addressid = Convert.ToInt32(dgAddress.SelectedRows[0].Cells["AddressId"].Value.ToString());
                int customerid = Convert.ToInt32(dgCustomers.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                CustomerService.Delete(customerid);

                
                AddressService.Delete(addressid);

                MessageBox.Show("Customer has Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeData();
                getAddress();
                txtCustomerName.Clear();
                txtDOB.Clear();
                txtPOB.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            dgCustomers.SelectionChanged += dgCustomers_SelectionChanged;
            dgAddress.SelectionChanged += dgAddress_SelectionChanged;

            dgAddress.MultiSelect = true;
            dgCustomers.MultiSelect = true;
        }

        private void dgAddress_SelectionChanged(object sender, EventArgs e)
        {


            if (dgAddress.SelectedRows.Count > 0)
            {

                int addressid = Convert.ToInt32(dgAddress.SelectedRows[0].Cells["AddressId"].Value.ToString());
                Address address = AddressService.Get(addressid);


                if (address != null)
                {
                    txtAddress.Text = address.AddressName;
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
