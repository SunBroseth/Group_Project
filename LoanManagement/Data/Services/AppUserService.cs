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
    public class AppUserService
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("AppUserGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter dapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            dapter.Fill(table);
            return table;
        }

        public static AppUser Get(int userid)
        {
            AppUser user = null;
            OracleCommand command = new OracleCommand("AppUserGet", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", userid);
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                user = new AppUser();
                user.AppUserId = Convert.ToInt32(reader["AppUserId"]);
                user.IsHidden = Convert.ToBoolean(reader["IsHidden"]);
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
                
            }
            return user;
        }

        public static void Add(AppUser appuser)
        {
            OracleCommand command = new OracleCommand("AppUserAdd", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_UserName", appuser.UserName);
            command.Parameters.Add("P_Password", appuser.Password);

            command.ExecuteNonQuery();
        }

        public static void Update(AppUser appuser)
        {
            OracleCommand command = new OracleCommand("AppUserUpdate", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_AppUserId", appuser.AppUserId);
            command.Parameters.Add("P_UserName", appuser.UserName);
            command.Parameters.Add("P_Password", appuser.Password);

            command.ExecuteNonQuery();
        }

        public static void Delete(int appuerid)
        {
            OracleCommand command = new OracleCommand("AppUserDelete", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appuerid);

            command.ExecuteNonQuery();
        }

        public static AppUser Login(string username, string password)
        {
            OracleCommand command = new OracleCommand("AppUserLogin", LoanContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_UserName", username);
            command.Parameters.Add("P_Password", password);

            OracleDataReader reader = command.ExecuteReader();
            AppUser user = null;
            if (reader.Read())
            {
                user = new AppUser();
                user.AppUserId = Convert.ToInt32(reader["AppUserId"]);
                user.IsHidden = Convert.ToBoolean(reader["IsHidden"]);
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
               
            }
            return user;
        }
    }
}
