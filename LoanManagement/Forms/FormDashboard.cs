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
    public partial class FormDashboard : Form
    {
        DataTable dtCustomer;
        FormMain formMain;
        public FormDashboard(FormMain formmain)
        {
            this.formMain = formmain;
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            dtCustomer = CustomerService.GetAll();

            dgCustomersHistory.DataSource = dtCustomer;


           
            dgCustomersHistory.Columns[0].Visible = false;


            dgCustomersHistory.Columns[1].Visible = false;

            dgCustomersHistory.Columns[2].HeaderText = "Customer History";
            dgCustomersHistory.Columns[2].Width = 300;
            dgCustomersHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomersHistory.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomersHistory.Columns[2].Visible = true;

            dgCustomersHistory.Columns[3].Visible = false;
            dgCustomersHistory.Columns[4].Visible = false;
            dgCustomersHistory.Columns[5].Visible = false;
            dgCustomersHistory.Columns[6].HeaderText = "Phone";
            dgCustomersHistory.Columns[6].Width = 300;
            dgCustomersHistory.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomersHistory.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomersHistory.Columns[6].Visible = true;
            dgCustomersHistory.Columns[7].Visible = false;






        }
    }
}
