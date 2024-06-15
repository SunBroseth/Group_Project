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
    public class CollateralService
    {
        public static DataTable GetAll()
        {

            OracleCommand command = new OracleCommand("CollateralGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }



        public static Collateral Get(int collateralid)
        {
            Collateral collateral = null;

            OracleCommand command = new OracleCommand("CollateralGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CollateralId", collateralid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                collateral = new Collateral();
                collateral.CollateralId = Convert.ToInt32(reader["CollateralId"].ToString());
                collateral.IsHidden = Convert.ToBoolean(reader["IsHidden"]);
                collateral.CollateralCode = reader["CollateralCode"].ToString();
                collateral.OwnerName = reader["OwnerName"].ToString();
                collateral.OwnerNationalCardNumber = reader["OwnerNationalCardNumber"].ToString();
               

                collateral.CollateralDescription = reader["CollateralDescription"].ToString();
             

            }





            return collateral;



        }

        public static void Add(Collateral collateral)
        {
            try
            {
                OracleCommand command = new OracleCommand("CollateralAdd", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add("P_CollateralCode", collateral.CollateralCode);
                command.Parameters.Add("P_OwnerName", collateral.OwnerName);
                command.Parameters.Add("P_OwnerNationalCardNumber", collateral.OwnerNationalCardNumber);
                command.Parameters.Add("P_CollateralTypeId", DBNull.Value);
                command.Parameters.Add("P_CollateralDescription", collateral.CollateralDescription);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(Collateral collateral)
        {
            try
            {
                OracleCommand command = new OracleCommand("CollateralUpdate", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CollateralId", collateral.CollateralId);
                command.Parameters.Add("P_CollateralCode", collateral.CollateralCode);
                command.Parameters.Add("P_OwnerName", collateral.OwnerName);
                command.Parameters.Add("P_OwnerNationalCardNumber", collateral.OwnerNationalCardNumber);
                command.Parameters.Add("P_CollateralTypeId", DBNull.Value);
                command.Parameters.Add("P_CollateralDescription", collateral.CollateralDescription);
              

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
                OracleCommand command = new OracleCommand("CollateralDelete", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CollateralId", customerid);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
