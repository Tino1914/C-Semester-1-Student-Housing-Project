using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Server_Manager
{
    public partial class RuleEditFormMOD : Form
    {
        ConnectSQL cs;
        private string ID;

        public RuleEditFormMOD(ConnectSQL consql, string i, string rule)
        {
            InitializeComponent();

            cs = consql;
            tbRule.Text = i;
            ID = i;
            tbModifyRule.Text = rule;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cs.UpdateInfoRule(ID, tbModifyRule.Text);
            this.Close();
        }
    }
}
