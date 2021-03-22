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

namespace Admin_UI
{
    public partial class ChangePassword : Form
    {
        private ConnectSQL cs;

        public ChangePassword(ConnectSQL consql)
        {
            InitializeComponent();
            AcceptButton = buttonConfirm;
            cs = consql;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text == textBoxNewPass.Text)
            {
                SqlConnection cnn = new SqlConnection(cs.ConStr);
                cnn.Open();

                SqlDataReader dataReader;
                SqlCommand cmd = cnn.CreateCommand();

                string sql = "SElECT Pass FROM AdminTable";
                string oldPass = "";

                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                    oldPass = dataReader.GetValue(0).ToString();

                cnn.Close();
                dataReader.Close();
                cmd.Dispose();

                if (textBoxOldPass.Text == oldPass)
                {
                    if (textBoxNewPass.Text != oldPass)
                    {
                        if (!String.IsNullOrEmpty(textBoxNewPass.Text))
                        {
                            cs.ChangePass(textBoxNewPass.Text);

                            labelNotify.Text = "Password updated successfully.";
                            labelNotify.ForeColor = Color.Green;

                            Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                            this.Close();
                        }
                        else
                        {
                            labelNotify.Text = "New password invalid, try a different one.";
                            labelNotify.ForeColor = Color.Red;
                            timer.Start();
                        }
                    }
                    else
                    {
                        labelNotify.Text = "Password cannot be the same as the current one.";
                        labelNotify.ForeColor = Color.Red;
                        timer.Start();
                    }
                }
                else
                {
                    labelNotify.Text = "Old password entered incorrectly.";
                    labelNotify.ForeColor = Color.Red;
                    timer.Start();
                }
            }
            else
            {
                labelNotify.Text = "New password does not match.";
                labelNotify.ForeColor = Color.Red;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelNotify.Text = "";
            timer.Stop();
        }
    }
}
