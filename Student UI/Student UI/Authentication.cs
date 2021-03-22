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
    public partial class Authentication : Form
    {
        private string name;
        private int counter = 0;
        private ConnectSQL cs;
        private WebSocket ws;

        public Authentication(ConnectSQL consql, string name)
        {
            InitializeComponent();
            labelName.Text = name;
            this.name = name;
            cs = consql;

            if (Form1.connected == true)
            {
                ws = new WebSocket();
                ws.connect(Form1.LocalIP, Form1.LocalPort, Form1.RemoteIP, Form1.RemotePort);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelNotify.Text = "";
            timer.Stop();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxCode.TextLength >= 4)
            {
                if (counter == 3)
                {
                    if (Form1.connected == true)
                    {
                        DialogResult message = MessageBox.Show("Have you forgotten your 4-digit code. Contact an admin for assistance?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (message == DialogResult.Yes)
                            ws.sendMsg("HELP" + name);
                    }
                }

                SqlConnection cnn = new SqlConnection(cs.ConStr);
                cnn.Open();

                SqlDataReader dataReader;
                SqlCommand cmd = cnn.CreateCommand();

                string sql = "SElECT FirstName, PinCode FROM StudentTable";
                string pass = "";

                cmd = new SqlCommand(sql, cnn);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                    if (name == dataReader.GetValue(0).ToString())
                    {
                        pass = dataReader.GetValue(1).ToString();
                        break;
                    }

                cnn.Close();
                dataReader.Close();
                cmd.Dispose();

                if (textBoxCode.Text == pass)
                {
                    labelNotify.ForeColor = Color.Green;
                    labelNotify.Text = "Task marked completed";

                    string task = Form1.listView.FindItemWithText(name).SubItems[2].Text;
                    string place = Form1.listView.FindItemWithText(name).SubItems[2].Text.Remove(task.IndexOf("."));
                    task = task.Substring(task.IndexOf(". ") + 2);
                    int points = 10;

                    if (task == "Groceries")
                        points = 20;
                    else if (task == "Maintenance")
                        points = 15;
                    else if (task == "Buying Essentials")
                        points = 20;

                    if (place == "Kit")
                        place = "Kitchen";
                    else if (place == "Res")
                        place = "Restrooms";
                    else if (place == "Com")
                        place = "Common Area";
                    else if (place == "Hal")
                        place = "Hallway";

                    cs.EndTask(name, task, points, place);

                    Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    Form1.listView.Items.RemoveAt(Form1.index);

                    Close();
                }
                else
                {
                    labelNotify.ForeColor = Color.Red;
                    labelNotify.Text = "Access denied";
                    counter++;
                    timer.Start();
                }

                textBoxCode.Text = "";
                timerTextControl.Start();
            }
        }
    }
}
