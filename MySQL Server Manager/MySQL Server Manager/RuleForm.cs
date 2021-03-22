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

namespace MySQL_Server_Manager
{
    public partial class RuleForm : Form
    {
        ConnectSQL cs;

        public RuleForm(ConnectSQL consql)
        {
            InitializeComponent();

            cs = consql;
            LoadList();
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Are you sure you want to remove this rule? \n(Removal is permanent)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cs.DeleteInfo("DELETE RuleTable WHERE RuleID = " + listView.SelectedItems[0].Text);
                    LoadList();
                }
            }
            else if (listView.SelectedItems.Count > 1)
            {
                if (MessageBox.Show("You are about to remove multiple rules. \nAre you sure you want to remove all the selected? \n(Removal is permanent)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i < listView.SelectedItems.Count; i++)
                        cs.DeleteInfo("DELETE RuleTable WHERE RuleID = " + listView.SelectedItems[i].Text);
                    LoadList();
                }
            }
        }

        public void LoadList()
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string ID = listView.SelectedItems[0].Text;
                string rule = listView.SelectedItems[0].SubItems[1].Text;

                Form RuleEditorMOD = new RuleEditFormMOD(cs, ID, rule);
                RuleEditorMOD.ShowDialog();

                LoadList();
            }
        }

        private void btnCreateNewRule_Click(object sender, EventArgs e)
        {
            int number = 1;
            if (listView.Items.Count != 0)
                number = Convert.ToInt32(listView.Items[listView.Items.Count - 1].Text) + 1;

            string ID = number.ToString();

            Form RuleEditor = new RuleEditForm(cs, ID);
            RuleEditor.ShowDialog();

            LoadList();
        }
    }
}
