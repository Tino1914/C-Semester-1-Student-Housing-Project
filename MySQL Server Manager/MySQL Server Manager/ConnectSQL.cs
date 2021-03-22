using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MySQL_Server_Manager
{
    public class ConnectSQL
    {
        private string connectionString;
        private string userID;
        private string password;

        public string ConStr { get { return this.connectionString; } set { this.connectionString = value; } }
        public string User { get { return this.userID; } private set { this.userID = value; } }
        public string Password { get { return this.password; } private set { this.password = value; } }

        public ConnectSQL(string dataSource, string user, string password)
        {
            connectionString = dataSource + "; User ID = " + user + "; Password = " + password;

            //Example: @"Data Source=217.105.46.198;Initial Catalog=MySQL;Persist Security Info=True;User ID=admin;Password=admin"

            this.ConStr = connectionString;
            this.userID = user;
            this.password = password;
        }

        public void DeleteInfo(string sql)
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            cmd = new SqlCommand(sql, cnn);

            dataAdapter.DeleteCommand = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            cmd.Dispose();
            cnn.Close();
        }

        public void UpdateInfo(string ID, string f, string l, string e, string d, string t, string c)
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            List<string> var = new List<string> { "FirstName", "LastName", "Email", "DailyPoints", "TotalPoints", "PinCode" };
            List<string> data = new List<string> { f, l, e, d, t, c };

            string sql = "";
            for (int i = 0; i < 6; i++)
            {
                sql = "UPDATE StudentTable SET " + var[i] + " = '" + data[i] + "' WHERE StudentID = " + ID;
                cmd = new SqlCommand(sql, cnn);

                dataAdapter.UpdateCommand = new SqlCommand(sql, cnn);
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                cmd.Dispose();
            }
            cnn.Close();
        }

        public void UpdateInfoRule(string ID, string r)
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            string sql = "UPDATE RuleTable SET RuleDescription = '" + r + "' WHERE RuleID = " + ID;
            cmd = new SqlCommand(sql, cnn);

            dataAdapter.UpdateCommand = new SqlCommand(sql, cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            cmd.Dispose();

            cnn.Close();
        }

        public void ClearAll()
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            List<string> tables = new List<string> { "StudentTable", "TaskTable", "RuleTable", "AdminTable" };
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            for (int i = 0; i < tables.Count; i++)
            {
                dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM " + tables[i], cnn);
                dataAdapter.DeleteCommand.ExecuteNonQuery();
                dataAdapter.Dispose();
            }

            dataAdapter.UpdateCommand = new SqlCommand("INSERT INTO AdminTable(Pass, Complaints) VALUES('admin', 0)", cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
