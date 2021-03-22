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
    public partial class ProgressForm : Form
    {
        private int subInt, total;
        private bool done;
        private ConnectSQL cs;

        public ProgressForm(string main, int size, ConnectSQL cs)
        {
            InitializeComponent();
            labelMain.Text = main;
            progressBarSub.Maximum = size;
            progressBarMain.MarqueeAnimationSpeed = 1;
            subInt = 0;
            this.cs = cs;
            total = MainForm.SQLs.Count;

            timerSub.Start();
            timerLabel.Start();
        }

        private void TimerSub_Tick(object sender, EventArgs e)
        {
            if (subInt < MainForm.SQLs.Count())
            {
                SqlConnection cnn = new SqlConnection(cs.ConStr);
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = MainForm.SQLs[subInt];

                cmd.ExecuteNonQuery();
                cnn.Close();
                cmd.Dispose();

                progressBarSub.Increment(subInt);

                Task.Delay(TimeSpan.FromSeconds(0.01)).Wait();
            }
            else
                done = true;

            subInt++;
            if (subInt == progressBarMain.Maximum)
            {
                this.Close();
                MainForm.SQLs.Clear();
                MainForm.progressInfo.Clear();
                MessageBox.Show($"Successfully uploaded {total.ToString()} new profiles to the SQL database", "Task Finished Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TimerLabel_Tick(object sender, EventArgs e)
        {
            if (!done)
            {
                Random number = new Random();
                int index = number.Next(MainForm.progressInfo.Count);
                labelSub.Text = MainForm.progressInfo[index];
            }
            else
                labelSub.Text = "Finishing Up...";
        }
    }
}
