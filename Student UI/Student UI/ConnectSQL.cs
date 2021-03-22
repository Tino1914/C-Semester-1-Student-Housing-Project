using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_UI
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

        public void UpdatePoints(string name)
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            int dp = 0;
            int tp = 0;
            using (SqlCommand cmdCount = new SqlCommand("SELECT DailyPoints FROM StudentTable WHERE FirstName = '" + name + "'", cnn))
            {
                dp = (int)cmdCount.ExecuteScalar();
            }
            using (SqlCommand cmdCount = new SqlCommand("SELECT TotalPoints FROM StudentTable WHERE FirstName = '" + name + "'", cnn))
            {
                tp = (int)cmdCount.ExecuteScalar();
            }
            tp += dp;
            dp = 0;

            dataAdapter.UpdateCommand = new SqlCommand("UPDATE StudentTable SET TotalPoints = '" + tp + "', DailyPoints = '" + dp + "' WHERE FirstName = '" + name + "'", cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            cnn.Close();
        }

        public void SetTask(string name, string task, string day, string place)
        {
            int ID = 0;
            using (SqlConnection cnn = new SqlConnection(this.connectionString))
            {
                cnn.Open();

                using (SqlCommand cmdCount = new SqlCommand("SELECT StudentID FROM StudentTable WHERE FirstName = '" + name + "'", cnn))
                    ID = (int)cmdCount.ExecuteScalar();

                List<string> taskList = new List<string> { "Cleaning", "Groceries", "Maintenance", "BuyingEss" };
                int index = 0;
                if (task == "Groceries")
                    index = 1;
                else if (task == "Maintenance")
                    index = 2;
                else if (task == "Buying Essentials")
                    index = 3;

                SqlDataReader dataReader;
                SqlCommand cmd = cnn.CreateCommand();

                cmd = new SqlCommand("INSERT INTO TaskTable(StudentID, Status, Place, " + taskList[index] +") VALUES(" + ID + ", 'In Progress', '" + place + "', '" + day + "')", cnn);
                dataReader = cmd.ExecuteReader();

                cmd.Dispose();
                cnn.Close();
            }
        }

        public void EndTask(string name, string task, int points, string place)
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();
            int ID = 0;

            SqlCommand cmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            SqlCommand cmdCount = new SqlCommand("SELECT StudentID FROM StudentTable WHERE FirstName = '" + name + "'", cnn);
                ID = (int)cmdCount.ExecuteScalar();

            string sqls = "UPDATE TaskTable SET Status = 'Completed' WHERE StudentID = " + ID + " AND Status = 'In Progress' AND Place = '" + place + "'";
            cmd = new SqlCommand(sqls, cnn);

            dataAdapter.UpdateCommand = new SqlCommand(sqls, cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            int c = 0;
            using (SqlCommand cmdp = new SqlCommand("SELECT DailyPoints FROM StudentTable WHERE FirstName = '" + name + "' AND StudentID = " + ID, cnn))
                c = (int)cmdp.ExecuteScalar();

            points += c;
            string sql = "UPDATE StudentTable SET DailyPoints = '" + points.ToString() + "' WHERE FirstName = '" + name + "' AND StudentID = " + ID;
            cmd = new SqlCommand(sql, cnn);

            dataAdapter.UpdateCommand = new SqlCommand(sql, cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            cmd.Dispose();
            cnn.Close();
        }

        public List<string> GetInfo(string name)
        {
            List<string> info = new List<string> { name };
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT LastName, Email FROM StudentTable WHERE FirstName = '" + name + "'", cnn))
            {
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    info.Add(da.GetString(0));
                    info.Add(da.GetString(1));
                }
                da.Close();
            }
            cnn.Close();
            return info;
        }

        public void AddComplaint()
        {
            SqlConnection cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE AdminTable SET Complaints = Complaints + 1", cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
