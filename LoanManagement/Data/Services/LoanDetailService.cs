using LoanManagement.Data.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagement.Data.Services
{
    public class LoanDetailService
    {
        //public static DataTable GetAll()
        //{

        //    OracleCommand command = new OracleCommand("LoanDetailGet", LoanContext.GetConnection());
        //    command.CommandType = CommandType.StoredProcedure;
        //    OracleDataAdapter adapter = new OracleDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;


        //}



        public static DataTable Get(int loandetailid)
        {
            OracleCommand cmd = new OracleCommand("LoanDetailsGet", LoanContext.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_LoanId", loandetailid);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;



        }

        public static void Add(LoanDetail loandetail)
        {
            try
            {
                OracleCommand command = new OracleCommand("LoanDetailAdd", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                
                command.Parameters.Add("P_LoanId", loandetail.LoanId);
                command.Parameters.Add("P_PeriodNo", loandetail.PeriodNo);
                command.Parameters.Add("P_BeginningBalance", loandetail.BeginningBalance);
                command.Parameters.Add("P_Principle", loandetail.Principle);
                command.Parameters.Add("P_Interest", loandetail.Interest);
                command.Parameters.Add("P_Payment", loandetail.Payment);
                command.Parameters.Add("P_EndingBalance", loandetail.EndingBalance);
                command.Parameters.Add("P_IsPaid", loandetail.IsPaid ? 1 : 0);
                command.Parameters.Add("P_PaidDate", loandetail.PaidDate);
                command.Parameters.Add("P_Note", loandetail.Note);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(LoanDetail loandetail)
        {
            try
            {
                OracleCommand command = new OracleCommand("LoanDetailUpdate", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_LoanDetailId", loandetail.LoanDetailId);
                command.Parameters.Add("P_LoanId", loandetail.LoanId);
                command.Parameters.Add("P_PeriodNo", loandetail.PeriodNo);
                command.Parameters.Add("P_BegginningBalance", loandetail.BeginningBalance);
                command.Parameters.Add("P_Principle", loandetail.Principle);
                command.Parameters.Add("P_Interest", loandetail.Interest);
                command.Parameters.Add("P_Payment", loandetail.Payment);
                command.Parameters.Add("P_EndingBalance", loandetail.EndingBalance);
                command.Parameters.Add("P_IsPaid", loandetail.IsPaid ? 1 : 0);
                command.Parameters.Add("P_PidDate", loandetail.PaidDate);
                command.Parameters.Add("P_Note", loandetail.Note);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(int loanid)
        {
            try
            {
                OracleCommand command = new OracleCommand("LoanDetailDelete", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_LoanId", loanid);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
