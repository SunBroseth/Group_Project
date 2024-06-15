using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Data.Models
{
    public class LoanDetail
    {
        public int LoanDetailId { get; set; }
        public int LoanId { get; set; }
        public int PeriodNo { get; set; }
        public double BeginningBalance { get; set; }
        public double Principle { get; set; }
        public double Interest { get; set; }
        public double Payment    { get; set; }
        public double EndingBalance { get; set; }
        public Boolean IsPaid { get; set; }
        public DateTime PaidDate { get; set; }
        public string Note { get; set; }
    }
}
