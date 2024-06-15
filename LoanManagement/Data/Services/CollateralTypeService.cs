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
    public class CollateralTypeService
    {
        public static DataTable GetAll()
        {

            OracleCommand command = new OracleCommand("CollateralTypeGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }



        public static CollateralType Get(int collateralid)
        {
            CollateralType collateral = null;

            OracleCommand command = new OracleCommand("CollateralTypeGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CollateralTypeId", collateralid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                collateral = new CollateralType();
                collateral.CollateralTypeId = Convert.ToInt32(reader["CollateralTypeId"].ToString());
                collateral.CollateralTypeName = reader["CollateralTypeName"].ToString();
               


            }





            return collateral;



        }

        public static void Add(CollateralType collateral)
        {
            try
            {
                OracleCommand command = new OracleCommand("CollateralTypeAdd", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add("P_CollateralTypeName", collateral.CollateralTypeName);
                


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(CollateralType collateral)
        {
            try
            {
                OracleCommand command = new OracleCommand("CollateralTypeUpdate", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CollateralTypeId", collateral.CollateralTypeId);
                command.Parameters.Add("P_CollateralTypeName", collateral.CollateralTypeName);
                


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
                OracleCommand command = new OracleCommand("CollateralTypeDelete", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CollateralTypeId", customerid);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
