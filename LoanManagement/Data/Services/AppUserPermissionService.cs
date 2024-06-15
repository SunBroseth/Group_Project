using LoanManagement.Data.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Data.Services
{
    public class AppUserPermissionService
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("AppUserPermissionGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public static DataTable Get(int appuserid)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_AppUserId", appuserid);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public static void Add(AppUserPermission permission)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionAdd", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.Add("P_AppUserId", permission.AppUserId);
            command.Parameters.Add("P_UserPermission", permission.UserPermission);

            command.ExecuteNonQuery();
        }
        public static void Delete(int appuerid)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionDelete", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_AppUserId", appuerid);

            command.ExecuteNonQuery();
        }
    }
}
