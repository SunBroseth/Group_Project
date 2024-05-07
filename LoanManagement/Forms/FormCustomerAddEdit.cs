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
    public partial class FormCustomerAddEdit : Form
    {
        bool newcustomer;
        bool newaddress;
        Customer _customer;
        Address _address;
        public FormCustomerAddEdit(Customer customer, Address address)
        {
            InitializeComponent();
            if (customer == null && address == null)
            {
                this._customer = new Customer();
                this._address = new Address();
                lblTitle.Text = "New Customer";
                this.newcustomer = true;
                this.newaddress = true;
                txtCustomerName.Focus();
                txtAddress.Focus();
            }
            else
            {
                this._customer = customer;
               this._address = address;
                this.newcustomer = false;
                this.newaddress = false;
                lblTitle.Text = "Edit Customer";
                InitializeData();
                txtCustomerName.Focus();
                txtAddress.Focus();
            }
        }

        void InitializeData()
        {
            txtCustomerName.Text = _customer.CustomerName;
            cboSex.Text = _customer.Sex;
            DOB.Value = _customer.DOB;
            txtPOB.Text = _customer.POB;
            txtPhone.Text = _customer.Phone;
            txtEmail.Text = _customer.Email;
            txtAddress.Text = _address.AddressName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _customer.CustomerName = txtCustomerName.Text.Trim();
            _customer.Sex = cboSex.Text.Trim();
            _customer.POB = txtPOB.Text.Trim();
            _customer.DOB = DOB.Value;
            _customer.Phone = txtPhone.Text.Trim();
            _customer.Email = txtEmail.Text.Trim();
            _address.AddressName = txtAddress.Text.Trim();
            if (newcustomer)
            {
                CustomerService.Add(_customer);
                
            }
            else
            {
                CustomerService.Update(_customer);
               
            }
            if (newaddress)
            {
                AddressService.Add(_address);
            }
            else
            {
                AddressService.Update(_address);
            }



            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
