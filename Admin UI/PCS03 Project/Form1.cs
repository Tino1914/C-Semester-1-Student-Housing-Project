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
    public partial class Form1 : Form
    {
        WebSocket ws = new WebSocket();
        public static ConnectSQL cs;

        public static string LocalIP, LocalPort, RemoteIP, RemotePort;
        public static string selectedRule, selectedRuleNumber, changeRule;
        public static bool connected;
        public static int StudentID;
        string message;

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

                textBoxLocalIP.Text = ws.GetLocalIP();
                textBoxLocalPort.Text = "80";
                textBoxRemotePort.Text = "1523";
                textBoxRemoteIP.Text = ws.GetLocalIP();
                timerMessage.Start();
                connected = false;
            }
        }

        private void Complaints()
        {
            message = message.Remove(0, 8);
            string nature = message.Substring(0, 4);
            string description = message.Remove(0, 4);

            if (nature == "Clea")
                nature = "Cleaning";
            else if (nature == "Groc")
                nature = "Groceries";
            else if (nature == "Tras")
                nature = "Trash";
            else if (nature == "Nois")
                nature = "Noise";
            else if (nature == "Work")
                nature = "Work Division";
            else if (nature == "Othe")
                nature = "Other";

            ListViewItem item = new ListViewItem("#" + cs.ComplaintCount()) ;

            item.SubItems.Add(nature);
            item.SubItems.Add(description);
            listViewComplaints.Items.Add(item);
        }

        public void LoadRules()
        {
            listView.Items.Clear();

            SqlConnection cnn = new SqlConnection(cs.ConStr);
            cnn.Open();

            SqlDataReader dataReader;
            SqlCommand cmd = cnn.CreateCommand();

            string sql = "SElECT RuleID, RuleDescription FROM RuleTable";

            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ListViewItem line = new ListViewItem(dataReader.GetValue(0).ToString());

                line.SubItems.Add(dataReader.GetValue(1).ToString());
                listView.Items.Add(line);
            }
            cnn.Close();
            dataReader.Close();
            cmd.Dispose();
        }

        private void BtnComplaint_Click(object sender, EventArgs e)
        {
            if (listViewComplaints.SelectedItems.Count > 0)
            {
                string s = listViewComplaints.SelectedItems[0].SubItems[1].Text;
                string t = listViewComplaints.SelectedItems[0].Text;

                if (MessageBox.Show("Resolve Issue?\n" + listViewComplaints.SelectedItems[0].SubItems[2].Text, "Complaint " + t + " regading " + s, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    listViewComplaints.Items.RemoveAt(listViewComplaints.SelectedItems[0].Index);
            }
        }

        private void BtnCreateNewRule_Click(object sender, EventArgs e)
        {
            int number = 1;
            if (listView.Items.Count != 0)
                number = Convert.ToInt32(listView.Items[listView.Items.Count - 1].Text) + 1;

            string ID = number.ToString();

            Form RuleEditor = new RuleEditForm(cs, ID);
            RuleEditor.ShowDialog();

            LoadRules();
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxEmail.Text != "")
                {
                    Random number = new Random();
                    int code = number.Next(1000, 10000);

                    SqlConnection cnn = new SqlConnection(cs.ConStr);
                    cnn.Open();

                    if(cs.StudentCount() == "0")
                    {
                        StudentID = 0;
                    }
                    else
                        using (SqlCommand cmdCount = new SqlCommand("SELECT max(StudentID) FROM StudentTable", cnn))
                        {
                            StudentID = (int)cmdCount.ExecuteScalar();
                            StudentID++;
                        }

                    SqlDataReader dataReader;
                    SqlCommand cmd = cnn.CreateCommand();
                    string name = textBoxFirstName.Text;

                    string sql = "INSERT INTO StudentTable(StudentID, FirstName, LastName, Email, DailyPoints, TotalPoints, PinCode) VALUES('" + StudentID + "', '" + name + "', '" + textBoxLastName.Text + "', '" + textBoxEmail.Text + "', '" + 0 + "', '" + 0 + "', '" + code + "')";

                    cmd = new SqlCommand(sql, cnn);
                    dataReader = cmd.ExecuteReader();

                    StudentID++;
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxEmail.Clear();

                    MessageBox.Show("Welcome, " + name + ". Your 4-digit code is " + code.ToString() + ".");
                }
                else
                    MessageBox.Show("Please enter all missing feilds (First name, last name, email).", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connected == true)
                LoadRules();
            else
            {
                MessageBox.Show("Make sure you are connected and try again.", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
            }
        }

        private void ButtonSeeAllStudent_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                Form StudentList = new StudentList(cs);
                StudentList.ShowDialog();
            }
        }

        private void TimerInfo_Tick(object sender, EventArgs e)
        {
            if (connected)
            {
                labelStudents.Text = cs.StudentCount();
                labelTotalTasks.Text = cs.TaskCount();
                labelProgress.Text = cs.ProgressCount();
                labelComplaints.Text = cs.ComplaintCount();
                labelCompleted.Text = cs.DoneCount();
            }
        }

        private void BtnRemoveRule_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Are you sure you want to remove this rule? \n(Removal is permanent)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cs.DeleteInfo("DELETE RuleTable WHERE RuleID = " + listView.SelectedItems[0].Text);
                    LoadRules();
                }
            }
            else if (listView.SelectedItems.Count > 1)
            {
                if (MessageBox.Show("You are about to remove multiple rules. \nAre you sure you want to remove all the selected? \n(Removal is permanent)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i < listView.SelectedItems.Count; i++)
                        cs.DeleteInfo("DELETE RuleTable WHERE RuleID = " + listView.SelectedItems[i].Text);
                    LoadRules();
                }
            }
        }

        private void TimerMessage_Tick(object sender, EventArgs e)
        {
            foreach (string text in ws.messages)
                message = text;

            if (ws.messages.Count > 0)
            {
                if (message.Contains("COMP"))
                {
                    Complaints();

                    message = String.Empty;
                    ws.messages.Clear();
                }
                else if (message.Contains("HELP"))
                {
                    string name = message.Remove(0, 4);
                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add("Needs help authenticating 4-digit code (password loss)");
                    listViewComplaints.Items.Add(item);

                    message = String.Empty;
                    ws.messages.Clear();
                }
            }
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if(connected == true)
            {
                Form ChangePassword = new ChangePassword(cs);
                ChangePassword.Show();
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string ID = listView.SelectedItems[0].Text;
                string rule = listView.SelectedItems[0].SubItems[1].Text;

                Form RuleEditorMOD = new RuleEditFormMOD(cs, ID, rule);
                RuleEditorMOD.ShowDialog();

                LoadRules();
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
                    timerInfo.Start();
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
    }
}
