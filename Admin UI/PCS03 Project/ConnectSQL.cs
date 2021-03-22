using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Admin_UI
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

        public string StudentCount()
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            int s = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT max(StudentID) FROM StudentTable", cnn))
            {
                try
                {
                    s = (int)cmd.ExecuteScalar();
                    s++;
                }
                catch(Exception e)
                {
                    s = 0;
                }
            }
            cnn.Close();
            return s.ToString();
        }

        public string TaskCount()
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            int s = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM TaskTable", cnn))
            {
                s = (int)cmd.ExecuteScalar();
            }
            cnn.Close();
            return s.ToString();
        }

        public string ProgressCount()
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            int s = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT count(Status) FROM TaskTable WHERE Status = 'In Progress'", cnn))
            {
                s = (int)cmd.ExecuteScalar();
            }
            cnn.Close();
            return s.ToString();
        }

        public string DoneCount()
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            int s = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT count(Status) FROM TaskTable WHERE Status = 'Completed'", cnn))
            {
                s = (int)cmd.ExecuteScalar();
            }
            cnn.Close();
            return s.ToString();
        }

        public string ComplaintCount()
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            int s = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Complaints FROM AdminTable", cnn))
                {
                    s = (int)cmd.ExecuteScalar();
                }
            }
            catch(Exception e)
            {
                s = 0;
            }

            cnn.Close();
            return s.ToString();
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

        public void ChangePass(string pass)
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            string sql = "UPDATE AdminTable SET Pass = '" + pass + "'";
            cmd = new SqlCommand(sql, cnn);

            dataAdapter.UpdateCommand = new SqlCommand(sql, cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            cmd.Dispose();
            cnn.Close();
        }
    }
}
