using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Data.Models
{
    public class CreditOfficer
    {
        public int CreditOfficerId { get; set; }
        public Boolean IsHidden { get; set; }
        public string CreditOfficerName { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public string POB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
