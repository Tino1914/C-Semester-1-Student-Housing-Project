using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_UI
{
    public partial class UpdateInfoForm : Form
    {
        private string ID;
        ConnectSQL cs;

        public UpdateInfoForm(ConnectSQL consql, string i, string f, string l, string e, string c)
        {
            InitializeComponent();

            cs = consql;
            ID = i;

            textBoxC.Text = c;
            labelID.Text = i;
            textBoxF.Text = f;
            textBoxL.Text = l;
            textBoxE.Text = e;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            cs.UpdateInfo(ID, textBoxF.Text, textBoxL.Text, textBoxE.Text, textBoxC.Text);
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
