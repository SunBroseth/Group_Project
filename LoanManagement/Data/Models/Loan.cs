using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Data.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public Boolean IsHidden { get; set; }
        public int CustomerId { get; set; }
        public int CollateralId { get; set; }
        public int CreditOfficerId { get; set; }
        public DateTime LoanDate { get; set; }
        public string LoanCode { get; set; }
        public double LoanAmount { get; set; }
        public string Currency { get; set;}
        public double InterestRate { get; set; }
        public int PaymentFrequencyCode { get; set;}
        public string Memo {  get; set; }
    }
}
