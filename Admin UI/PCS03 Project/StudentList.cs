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
    public partial class StudentList : Form
    {
        ConnectSQL cs;
        private bool search;

        public StudentList(ConnectSQL consql)
        {
            InitializeComponent();
            cs = consql;
            search = false;

            comboBoxType.Items.AddRange(new string[] { "StudentID", "First Name", "Last Name", "Email", "Daily Points", "Totla Points", "PinCode" });
            LoadList();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
                if (MessageBox.Show("Are you sure you want to remove this student? \n(Removal is permanent)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    cs.DeleteInfo("DELETE StudentTable WHERE StudentID = " + listView.SelectedItems[0].Text);
            if (listView.SelectedItems.Count > 1)
                if (MessageBox.Show("You are about to remove multiple student profiles. \nAre you sure you want to remove all the selected? \n(Removal is permanent)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    for (int i = 0; i < listView.SelectedItems.Count; i++)
                        cs.DeleteInfo("DELETE StudentTable WHERE StudentID = " + listView.SelectedItems[i].Text);

            LoadList();
        }

        public void LoadList()
        {
            listView.Items.Clear();

            SqlConnection cnn = new SqlConnection(cs.ConStr);
            cnn.Open();

            SqlDataReader dataReader;
            SqlCommand cmd = cnn.CreateCommand();

            string sql = "";
            if (!search)
                sql = "SElECT StudentID, FirstName, LastName, Email, DailyPoints, TotalPoints, PinCode FROM StudentTable";
            else
                if (int.TryParse(textBoxFilter.Text, out int num))
                sql = "SElECT StudentID, FirstName, LastName, Email, DailyPoints, TotalPoints, PinCode FROM StudentTable WHERE " + comboBoxType.Text.Replace(" ", "") + " = " + textBoxFilter.Text;
            else
                sql = "SElECT StudentID, FirstName, LastName, Email, DailyPoints, TotalPoints, PinCode FROM StudentTable WHERE " + comboBoxType.Text.Replace(" ", "") + " = '" + textBoxFilter.Text.Remove(1).ToUpper() + textBoxFilter.Text.Substring(1) + "'";

            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();

            string dataLine = "";
            while (dataReader.Read())
            {
                dataLine = dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "-" + dataReader.GetValue(2) + "-" + dataReader.GetValue(3) + "-" + dataReader.GetValue(4) + "-" + dataReader.GetValue(5) + "-" + dataReader.GetValue(6);

                string var = dataLine;
                ListViewItem line = new ListViewItem(var.Remove(var.IndexOf("-")));
                for (int x = 0; x < 5; x++)
                {
                    var = var.Substring(var.IndexOf("-") + 1);
                    line.SubItems.Add(var.Remove(var.IndexOf("-")));
                }
                line.SubItems.Add(var.Substring(var.LastIndexOf("-") + 1));
                listView.Items.Add(line);
            }
            cnn.Close();
            dataReader.Close();
            cmd.Dispose();

            search = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string ID = listView.SelectedItems[0].Text;
                string Fame = listView.SelectedItems[0].SubItems[1].Text;
                string Lame = listView.SelectedItems[0].SubItems[2].Text;
                string Email = listView.SelectedItems[0].SubItems[3].Text;
                string Dpoints = listView.SelectedItems[0].SubItems[4].Text;
                string Tpoints = listView.SelectedItems[0].SubItems[5].Text;
                string Code = listView.SelectedItems[0].SubItems[6].Text;

                Form UpdateInfoForm = new UpdateInfoForm(cs, ID, Fame, Lame, Email, Dpoints, Tpoints, Code);
                UpdateInfoForm.ShowDialog();

                LoadList();
            }
        }

        private void ButtonRemoveAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to clear all student from list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                if(MessageBox.Show("Confirm changes. Hit 'Yes' to confirm, 'No' to cancel.", "Last Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i < listView.Items.Count; i++)
                        cs.DeleteInfo("DELETE StudentTable WHERE StudentID = " + listView.Items[i].Text);
                    LoadList();

                    MessageBox.Show("Fair is foul, and foul is fair.");
                }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedIndex != -1 && textBoxFilter.Text != "")
                search = true;

            LoadList();
        }
    }
}
