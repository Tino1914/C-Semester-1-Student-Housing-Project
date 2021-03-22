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
    public partial class RuleEditForm : Form
    {
        ConnectSQL cs;
        private string ID;

        public RuleEditForm(ConnectSQL consql, string i)
        {
            InitializeComponent();

            cs = consql;
            tbRule.Text = i;
            ID = i;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(cs.ConStr);
            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            string sql = "INSERT INTO RuleTable(RuleID, RuleDescription) VALUES(" + "'" + ID + "','" + tbModifyRule.Text + "') ";
            cmd = new SqlCommand(sql, cnn);

            dataAdapter.UpdateCommand = new SqlCommand(sql, cnn);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            cmd.Dispose();

            cnn.Close();
            this.Close();
        }
    }
}
