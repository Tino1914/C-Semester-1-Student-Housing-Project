using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Personal_UI
{
    public class ConnectSQL
    {
        private SqlConnection cnn;
        private string userReader;
        private string un;
        private string first;
        private string last;
        private string email;
        private int studentID;
        private int dpo;
        private int tpo;
        private int pin;
        private string cs;

        public string First { get { return first; } }
        public string Last { get { return last; } }
        public string Email { get { return email; } }
        public int StudentID { get { return studentID; } }
        public int DPO { get { return dpo; } }
        public int TPO { get { return tpo; } }
        public int PinCode { get { return pin; } }
        public string ConStr { get { return cs; } }

        public ConnectSQL()
        {
            cs = @"Data Source=217.105.46.198;Initial Catalog=MySQL;Persist Security Info=True;User ID=admin;Password=admin";
            cnn = new SqlConnection(@"Data Source=217.105.46.198;Initial Catalog=MySQL;Persist Security Info=True;User ID=admin;Password=admin");
        }

        public bool UsernamePassword(string username, string password)
        {
            cnn.Open();

            un = username;
            if (int.TryParse(username, out int num))
                using (SqlCommand cmd = new SqlCommand("SELECT PinCode FROM StudentTable WHERE StudentID = " + username, cnn))
                    try
                    {
                        if ((int)cmd.ExecuteScalar() == Convert.ToInt32(password))
                        {
                            userReader = "StudentID";
                            cnn.Close();
                            return true;
                        }
                    }
                    catch (Exception ex) { }

            if(!int.TryParse(username, out int digit))
                username = username.Remove(1).ToUpper() + username.Substring(1);

            List<string> var = new List<string>{ "FirstName", "LastName", "Email" };

            for (int i = 0; i < var.Count; i++)
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PinCode FROM StudentTable WHERE " + var[i] + " = '" + username + "'", cnn))
                {
                    try
                    {
                        if ((int)cmd.ExecuteScalar() == Convert.ToInt32(password))
                        {
                            userReader = var[i];
                            cnn.Close();
                            return true;
                        }
                    }
                    catch (Exception ex) { }
                }
            }

            cnn.Close();
            return false;
        }

        public void GetSQLInfo()
        {
            cnn.Open();

            if(un.Length > 1)
                un = un.Remove(1).ToUpper() + un.Substring(1);
            if (!int.TryParse(un, out int num))
                un = "'" + un.ToString() + "'";

            using (SqlCommand cmd = new SqlCommand("SELECT StudentID, FirstName, LastName, Email, Dailypoints, TotalPoints, PinCode FROM StudentTable WHERE " + userReader + " = " + un, cnn))
            {
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    studentID = Convert.ToInt32(da.GetValue(0));
                    first = da.GetValue(1).ToString();
                    last = da.GetValue(2).ToString();
                    email = da.GetValue(3).ToString();
                    dpo = Convert.ToInt32(da.GetValue(4));
                    tpo = Convert.ToInt32(da.GetValue(5));
                    pin = Convert.ToInt32(da.GetValue(6));
                }
                da.Close();
            }
            cnn.Close();
        }

        public void UpdateInfo(string ID, string f, string l, string e, string c)
        {
            cnn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            List<string> var = new List<string> { "FirstName", "LastName", "Email", "PinCode" };
            List<string> data = new List<string> { f, l, e, c };

            for (int i = 0; i < 4; i++)
            {
                dataAdapter.UpdateCommand = new SqlCommand("UPDATE StudentTable SET " + var[i] + " = '" + data[i] + "' WHERE StudentID = " + ID, cnn);
                dataAdapter.UpdateCommand.ExecuteNonQuery();
            }
            cnn.Close();
        }

        public void AddComplaint()
        {
            cnn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE AdminTable SET Complaints = Complaints + 1", cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
