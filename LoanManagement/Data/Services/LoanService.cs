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
    public class LoanService
    {
        public static DataTable GetAll()
        {

            OracleCommand command = new OracleCommand("LoanGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

            
        }



        public static Loan Get(int loanid)
        {
            Loan loan = null;

            OracleCommand command = new OracleCommand("LoanGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_LoanId", loanid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                loan = new Loan();
                loan.LoanId = Convert.ToInt32(reader["LoanId"].ToString());
                loan.IsHidden = Convert.ToBoolean(reader["IsHidden"]);
                
                loan.CustomerId = Convert.ToInt32(reader["CustomerId"].ToString());
                loan.CollateralId = Convert.ToInt32(reader["CollateralId"].ToString());
                loan.CreditOfficerId = Convert.ToInt32(reader["CreditOfficerId"].ToString());
                
                loan.LoanDate = Convert.ToDateTime(reader["LoanDate"].ToString());
                loan.LoanCode = reader["LoanCode"].ToString();
                loan.Currency = reader["Email"].ToString();
                loan.InterestRate = Convert.ToDouble(reader["InterestRate"].ToString());
                loan.PaymentFrequencyCode = Convert.ToInt32(reader["PaymentFrequencyCode"].ToString());
                loan.Memo = reader["Memo"].ToString();
               


            }





            return loan;



        }

        public static int Add(Loan loan)
        {
            int loanid = 0;
            try
            {
                OracleCommand command = new OracleCommand("LoanAdd", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add("P_CustomerId", loan.CustomerId);
                command.Parameters.Add("P_CollateralId", loan.CollateralId);
                command.Parameters.Add("P_CreditOfficerId", loan.CreditOfficerId);
                command.Parameters.Add("P_LoanDate", loan.LoanDate);
                command.Parameters.Add("P_LoanCode", loan.LoanCode);
                command.Parameters.Add("P_LoanAmount", loan.LoanAmount);
                command.Parameters.Add("P_Currency", loan.Currency);
                command.Parameters.Add("P_InterestRate", loan.InterestRate);
                command.Parameters.Add("P_PaymentFrequencyCode", loan.PaymentFrequencyCode);
                command.Parameters.Add("P_Memo", loan.Memo);
                command.Parameters.Add("P_LoanId", OracleDbType.Int32, ParameterDirection.Output);

                command.ExecuteNonQuery();
                loanid = Convert.ToInt32(command.Parameters["P_LoanId"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loanid;
        }

        public static void Update(Loan loan)
        {
            try
            {
                OracleCommand command = new OracleCommand("LoanUpdate", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_LoanId", loan.LoanId);
                command.Parameters.Add("P_CustomerId", loan.CustomerId);
                command.Parameters.Add("P_CollateralId", loan.CollateralId);
                command.Parameters.Add("P_CreditOfficerId", loan.CreditOfficerId);
                command.Parameters.Add("P_LoanDate", loan.LoanDate);
                command.Parameters.Add("P_LoanCode", loan.LoanCode);
                command.Parameters.Add("P_LoanAmount", loan.LoanAmount);
                command.Parameters.Add("P_Currency", loan.Currency);
                command.Parameters.Add("P_InterestRate", loan.InterestRate);
                command.Parameters.Add("P_PaymentFrequencyCode", loan.PaymentFrequencyCode);
                command.Parameters.Add("P_Memo", loan.Memo);

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
                OracleCommand command = new OracleCommand("LoanDelete", LoanContext.GetConnection());
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
