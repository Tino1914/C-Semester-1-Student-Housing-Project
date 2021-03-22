using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_UI
{
    public partial class Form1 : Form
    {
        WebSocket ws = new WebSocket();
        public static ConnectSQL cs;

        public static string rulesUpdate, LocalIP, RemoteIP, LocalPort, RemotePort;
        public static int index;
        public static bool connected;
        private string current, old;
        private int compID;

        public Form1()
        {
            if (ws.GetLocalIP() == "127.0.0.1")
            {
                MessageBox.Show("Device not connected to internet. Check connection and retry.");
                Environment.Exit(0);
            }
            else
            {
                InitializeComponent();

                comboBoxNature.Items.AddRange(new string[] { "Cleaning", "Groceries", "Trash", "Noise", "Work Division", "Maintenance", "Other" });
                comboBoxCategory.Items.AddRange(new string[] { "Kitchen", "Restrooms", "Common Area", "Hallway" });

                textBoxLocalPort.Text = "1523";
                textBoxRemoteIP.Text = ws.GetLocalIP();
                textBoxRemotePort.Text = "80";
                textBoxLocalIP.Text = ws.GetLocalIP();

                timerDate.Start();
                timerUpdate.Start();

                connected = false;
                compID = 0;
                current = DateTime.Now.ToString("dddd");
                rulesUpdate = "Last updated on: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            }
        }

        public void LoadList()
        {
            comboBoxName.Items.Clear();
            SqlConnection cnn = new SqlConnection(cs.ConStr);
            cnn.Open();

            SqlDataReader dataReader;
            SqlCommand cmd = cnn.CreateCommand();

            string sql = "SElECT FirstName, LastName FROM StudentTable";
            string dataLine = "";

            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                dataLine = dataReader.GetValue(0) + " " + dataReader.GetValue(1);
                comboBoxName.Items.Add(dataLine);
            }

            cnn.Close();
            dataReader.Close();
            cmd.Dispose();
        }

        private void ButtonSetTask_Click(object sender, EventArgs e)
        {
            if (comboBoxTask.Text != "" && comboBoxName.Text != "")
            {
                string date = DateTime.Now.ToString("dddd");

                cs.SetTask(comboBoxName.Text.Remove(comboBoxName.Text.IndexOf(" ")), comboBoxTask.Text, date, comboBoxCategory.Text);

                if (date == "Monday")
                    date = "Day 1";
                else if (date == "Tuesday")
                    date = "Day 2";
                else if (date == "Wednesday")
                    date = "Day 3";
                else if (date == "Thursday")
                    date = "Day 4";
                else if (date == "Friday")
                    date = "Day 5";
                else if (date == "Saturday")
                    date = "Day 6";
                else if (date == "Sunday")
                    date = "Day 7";

                ListViewItem item = new ListViewItem(comboBoxName.Text.Remove(comboBoxName.Text.IndexOf(" ")));
                item.SubItems.Add(date);
                item.SubItems.Add(comboBoxCategory.Text.Remove(3) + ". " + comboBoxTask.Text);
                listView.Items.Add(item);

                comboBoxName.Items.Remove(comboBoxName.Text);

                comboBoxName.SelectedIndex = -1;
                comboBoxCategory.SelectedIndex = -1;
                comboBoxTask.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Missing Information. (have you added a task after selecting category?)");
        }

        private void ButtonStudentInfo_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count > 0)
            {
                List<string> info = new List<string>();
                info = cs.GetInfo(listView.SelectedItems[0].Text);
                MessageBox.Show(info[0] + " " + info[1] + " (" + info[2] + ")");
            }
        }

        private void TimerDate_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dddd");
        }

        private void ButtonTaskComplete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                index = listView.Items.IndexOf(listView.SelectedItems[0]);
                LoadList();

                Form Authentication = new Authentication(cs, listView.SelectedItems[0].Text.Trim());
                Authentication.Show();
            }
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTask.Items.Clear();

            if (comboBoxCategory.Text == "Kitchen")
                comboBoxTask.Items.AddRange(new string[] { "Maintenance", "Cleaning", "Groceries" });
            else if (comboBoxCategory.Text == "Restrooms")
                comboBoxTask.Items.AddRange(new string[] { "Maintenance", "Cleaning", "Buying Essentials" });
            else if (comboBoxCategory.Text == "Common Area")
                comboBoxTask.Items.AddRange(new string[] { "Maintenance", "Cleaning" });
            else if (comboBoxCategory.Text == "Hallway")
                comboBoxTask.Items.AddRange(new string[] { "Maintenance", "Cleaning" });
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            if(old != current)
                if(old == "Sunday" && current == "Monday")
                {
                    for (int i = 0; i < listView.Items.Count; i++)
                        cs.UpdatePoints(listView.Items[i].Text);

                    listView.Items.Clear();
                    LoadList();
                }

            current = DateTime.Now.ToString("dddd");
            old = current;
        }

        private void ButtonRules_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                Form Rules = new Rules(cs);
                Rules.Show();
            }
        }

        private void ButtonSeeAllStudent_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                Form AdminLog = new AdminLog(cs, "main");
                AdminLog.Show();
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (connected == false)
            {
                LocalIP = textBoxLocalIP.Text;
                RemoteIP = textBoxRemoteIP.Text;
                LocalPort = textBoxLocalPort.Text;
                RemotePort = textBoxRemotePort.Text;

                if (textBoxLocalPort.Text != textBoxRemotePort.Text)
                {
                    ws.connect(LocalIP, LocalPort, RemoteIP, RemotePort);
                    Form ConnectForm = new ConnectForm();
                    ConnectForm.ShowDialog();
                    LoadList();
                }
                else
                    MessageBox.Show("Incorrect connection details!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (ws.connection)
                    connected = true;
                else
                    connected = false;

                Size = new Size(568, 498);
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                if (comboBoxNature.Text != "" && textBoxDescription.Text != "")
                {
                    string nature = comboBoxNature.Text;
                    string descriprtion = textBoxDescription.Text;
                    compID++;

                    if (nature == "Clean")
                        nature = "Clea";
                    else if (nature == "Groceries")
                        nature = "Groc";
                    else if (nature == "Trash")
                        nature = "Tras";
                    else if (nature == "Noise")
                        nature = "Nois";
                    else if (nature == "Work Division")
                        nature = "Work";
                    else if (nature == "Maintenance")
                        nature = "Main";
                    else if (nature == "Other")
                        nature = "Othe";

                    ws.sendMsg("COMP" + compID.ToString("000") + " " + nature + " " + descriprtion);

                    comboBoxNature.SelectedIndex = -1;
                    textBoxDescription.Text = "";

                    cs.AddComplaint();

                    MessageBox.Show("Complaint has been submited and will be reviewed sortly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The nature and description of the complaint must be filled in.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Currently not connected. Press 'Connect' to connect to admin.", "Not connected.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}