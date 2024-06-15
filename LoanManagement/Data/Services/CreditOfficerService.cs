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
    public class CreditOfficerService
    {
        public static DataTable GetAll()
        {

            OracleCommand command = new OracleCommand("CreditOfficerGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }



        public static CreditOfficer Get(int customerid)
        {
            CreditOfficer customer = null;

            OracleCommand command = new OracleCommand("CreditOfficerGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CreditOfficerId", customerid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                customer = new CreditOfficer();
                customer.CreditOfficerId = Convert.ToInt32(reader["CreditOfficerId"].ToString());
                customer.IsHidden = Convert.ToBoolean(reader["IsHidden"]);
                customer.CreditOfficerName = reader["CreditOfficerName"].ToString();
                customer.Sex = reader["Sex"].ToString();
                customer.DOB = Convert.ToDateTime(reader["DOB"].ToString());
                customer.POB = reader["POB"].ToString();
               
                customer.Phone = reader["Phone"].ToString();
                customer.Email = reader["Email"].ToString();

            }





            return customer;



        }

        public static void Add(CreditOfficer creditofficer)
        {
            try
            {
                OracleCommand command = new OracleCommand("CreditOfficerAdd", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add("P_CreditOfficerName", creditofficer.CreditOfficerName);
                command.Parameters.Add("P_Sex", creditofficer.Sex);
                command.Parameters.Add("P_DOB", creditofficer.DOB);
                command.Parameters.Add("P_POB", creditofficer.POB);
                command.Parameters.Add("P_Phone", creditofficer.Phone);
                command.Parameters.Add("P_Email", creditofficer.Email);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(CreditOfficer creditofficer)
        {
            try
            {
                OracleCommand command = new OracleCommand("CreditOfficerUpdate", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CreditOfficerId", creditofficer.CreditOfficerId);
                command.Parameters.Add("P_CreditOfficerName", creditofficer.CreditOfficerName);
                command.Parameters.Add("P_Sex", creditofficer.Sex);
                command.Parameters.Add("P_DOB", creditofficer.DOB);
                command.Parameters.Add("P_POB", creditofficer.POB);
                command.Parameters.Add("P_Phone", creditofficer.Phone);
                command.Parameters.Add("P_Email", creditofficer.Email);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(int customerid)
        {
            try
            {
                OracleCommand command = new OracleCommand("CreditOfficerDelete", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CreditOfficerId", customerid);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
