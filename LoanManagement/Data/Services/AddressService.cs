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
    public class AddressService
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("AddressGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static Address Get(int addressid)
        {
            Address address = null;
            OracleCommand command = new OracleCommand("AddressGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AddressId", addressid);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                address = new Address();
                address.AddressId = Convert.ToInt32(reader["AddressId"].ToString());
                
                address.AddressName = reader["AddressName"].ToString();
            }
            return address;
        }

        public static void Add(Address address)
        {
            try
            {
                OracleCommand command = new OracleCommand("AddressAdd", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                
                command.Parameters.Add("P_AddressName", address.AddressName);
                

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(Address address)
        {
            try
            {
                OracleCommand command = new OracleCommand("AddressUpdate", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_AddressId", address.AddressId);
                
                command.Parameters.Add("P_AddressName", address.AddressName);
           

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(int addressid)
        {
            try
            {
                OracleCommand command = new OracleCommand("AddressDelete", LoanContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_AddressId", addressid);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
