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
using System.Net.Mail;

namespace Personal_UI
{
    public partial class LoginForm : Form
    {
        private ConnectSQL cs;

        public LoginForm(ConnectSQL consql)
        {
            InitializeComponent();
            cs = consql;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
                if(int.TryParse(textBoxPassword.Text, out int num))
                {
                    Convert.ToInt32(textBoxPassword.Text);
                    if (cs.UsernamePassword(textBoxUsername.Text, textBoxPassword.Text))
                    {
                        cs.GetSQLInfo();
                        MainForm.login = true;
                        this.Close();
                    }
                    else
                    {
                        labelStatus.ForeColor = Color.Red;
                        labelStatus.Text = "Invalid username or password.";
                        timerLabel.Start();
                        textBoxPassword.Clear();
                        textBoxUsername.Clear();
                    }
                }
                else
                    MessageBox.Show("You may only input 4 digts and not text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valid usernames include: first OR last name, email or StudentID.\nValid passwords include: 4-digit pin code.", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!MainForm.login)
                Environment.Exit(0);
        }

        private void TimerLabel_Tick(object sender, EventArgs e)
        {
            labelStatus.Text = "";
            timerLabel.Stop();
        }

        private void LabelForgot_Click(object sender, EventArgs e)
        {
            using (MailMessage mm = new MailMessage())
            {
                mm.From = new MailAddress("kirteen.kurtzer@gmail.com");
                mm.To.Add("greffnoah@gmail.com");
                mm.Subject = "This was sent via Visual Studios";
                mm.Body = "Hello.";

                using (SmtpClient sc = new SmtpClient("smtp.gmail.com", 587))
                {
                    sc.Credentials = new System.Net.NetworkCredential("kirteen.kurtzer@gmail.com", "fontyspassword");
                    sc.EnableSsl = true;
                    sc.Send(mm);
                }
            }
        }

        private void Label3_MouseHover(object sender, EventArgs e)
        {
            labelForgot.ForeColor = Color.Gray;
        }

        private void LabelForgot_MouseLeave(object sender, EventArgs e)
        {
            labelForgot.ForeColor = Color.Black;
        }
    }
}
