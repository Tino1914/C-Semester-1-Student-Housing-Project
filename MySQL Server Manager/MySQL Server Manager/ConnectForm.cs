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
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();

            textBoxConnectionString.Text = @"Data Source=217.105.46.198;Initial Catalog=MySQL;Persist Security Info=True";
            textBoxUserID.Text = "admin";
            textBoxPassword.Text = "admin";
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.cs = new ConnectSQL(textBoxConnectionString.Text, textBoxUserID.Text, textBoxPassword.Text);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
