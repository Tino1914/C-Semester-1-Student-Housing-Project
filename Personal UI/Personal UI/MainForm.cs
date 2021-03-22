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

namespace Personal_UI
{
    public partial class MainForm : Form
    {
        private ConnectSQL cs;
        private WebSocket ws;
        public static bool login;
        private int compID;
        private bool connected;
        public static string LocalIP, RemoteIP, LocalPort, RemotePort;

        public MainForm()
        {
            try
            { 
                cs = new ConnectSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ws = new WebSocket();
            Form Login = new LoginForm(cs);
            Login.ShowDialog();

            InitializeComponent();
            this.Text = "Profile - ID" + cs.StudentID;

            labelName.Text = cs.First + " " + cs.Last;
            labelEmail.Text = cs.Email;
            labelDPO.Text = cs.DPO.ToString();
            labelTPO.Text = cs.TPO.ToString();

            comboBoxNature.Items.AddRange(new string[] { "Cleaning", "Groceries", "Trash", "Noise", "Work Division", "Maintenance", "Other" });
            textBoxLocalPort.Text = "1523";
            textBoxRemoteIP.Text = ws.GetLocalIP();
            textBoxRemotePort.Text = "80";
            textBoxLocalIP.Text = ws.GetLocalIP();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Login = new LoginForm(cs);
            Login.Closed += (s, args) => this.Close();
            Login.ShowDialog();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            Form Rules = new Rules(cs);
            Rules.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(cs.ConStr);
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT StudentID, Status, Place, Cleaning, Groceries, Maintenance, BuyingEss FROM TaskTable WHERE StudentID = " + cs.StudentID, cnn))
            {
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                    if (Convert.ToInt32(da.GetValue(0)) == cs.StudentID)
                        for (int i = 3; i < 7; i++)
                            if (!String.IsNullOrEmpty(da.GetValue(i).ToString()))
                            {
                                string task = "Cleaning";
                                if (i == 4)
                                    task = "Groceries";
                                else if (i == 5)
                                    task = "Maintenance";
                                else if (i == 6)
                                    task = "Buying Essentials";

                                ListViewItem item = new ListViewItem(da.GetValue(i).ToString());
                                item.SubItems.Add(da.GetValue(2) + " - " + task);

                                if (da.GetValue(1).ToString() == "In Progress")
                                    listViewProgress.Items.Add(item);
                                else
                                    listViewDone.Items.Add(item);
                            }
                da.Close();
            }
            cnn.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
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

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            Form Edit = new UpdateInfoForm(cs, cs.StudentID.ToString(), cs.First, cs.Last, cs.Email, cs.PinCode.ToString());
            Edit.Show();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
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
