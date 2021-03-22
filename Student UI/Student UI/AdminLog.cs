using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_UI
{
    public partial class AdminLog : Form
    {
        private ConnectSQL cs;
        private int counter = 0;
        private string reason;
        public static string granted;

        public AdminLog(ConnectSQL consql, string reason)
        {
            InitializeComponent();
            cs = consql;
            this.reason = reason;
            granted = "NO";
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (counter == 3)
            {
                DialogResult message = MessageBox.Show("Are you an admin?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (message == DialogResult.Yes)
                {
                    MessageBox.Show("I'm pretty sure you're not.");
                }
                Close();
            }

            SqlConnection cnn = new SqlConnection(cs.ConStr);
            cnn.Open();

            SqlDataReader dataReader;
            SqlCommand cmd = cnn.CreateCommand();

            string sql = "SElECT Pass FROM AdminTable";
            string pass = "";

            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
                pass = dataReader.GetValue(0).ToString();

            cnn.Close();
            dataReader.Close();
            cmd.Dispose();

            if (textBoxCode.Text != pass)
            {
                labelNotify.ForeColor = Color.Red;
                labelNotify.Text = "Access denied";
                counter++;
                timer.Start();
            }
            else
            {
                labelNotify.ForeColor = Color.Green;
                labelNotify.Text = "Access granted";

                Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                this.Close();
                if (reason == "main")
                {
                    Form StudentList = new StudentList(cs);
                    StudentList.Show();
                }
                else
                    granted = "YES";
            }

            textBoxCode.Text = "";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelNotify.Text = "";
            timer.Stop();
        }
    }
}
