using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Data.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public Boolean IsHidden { get; set; }
        public string CustomerName { get; set; }
        public string Sex { get; set; }
        public string POB { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        Address add = new Address();
        
    }
}
