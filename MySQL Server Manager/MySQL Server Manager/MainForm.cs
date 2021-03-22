using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Server_Manager
{
    public partial class MainForm : Form
    {
        private string path, cmdLine;
        public static int StudentID;
        public static List<string> progressInfo = new List<string>();
        public static List<string> SQLs = new List<string>();
        public static ConnectSQL cs;

        public MainForm()
        {
            InitializeComponent();
            labelFile.Text = "(No File selected)";
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Form ConnectForm = new ConnectForm();
            ConnectForm.ShowDialog();

            Task.Delay(TimeSpan.FromSeconds(1.5)).Wait();
            comboBox.Items.Clear();
            comboBox.Items.AddRange(new string[] { "StudentTable", "RuleTable" });
            comboBox.SelectedIndex = 0;
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string fileName = "";

            if (ofd.ShowDialog() == DialogResult.OK)
                fileName = ofd.FileName;

            labelFile.Text = fileName;
            path = fileName;

            int count = 0;
            using (var reader = File.OpenText(path))
                while (reader.ReadLine() != null)
                    count++;
            labelc.Text = "(" + count.ToString() + ")";
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            if(cs != null)
            {
                cmdLine = textBoxCommandLine.Text;
                string ext = Path.GetExtension(path);
                bool good = true;

                while (ext != ".csv")
                {
                    if (MessageBox.Show($"Can not read file of type: '{ext}' \nReload new file?", "Error loading file.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        good = false;
                        break;
                    }

                    OpenFileDialog ofd = new OpenFileDialog();
                    string fileName = "";

                    if (ofd.ShowDialog() == DialogResult.OK)
                        fileName = ofd.FileName;

                    labelFile.Text = fileName;
                    path = fileName;

                    ext = Path.GetExtension(path);
                }

                if (good)
                {
                    int size = 0;
                    int fullSize = 0;

                    using (var reader = File.OpenText(path))
                        while (reader.ReadLine() != null)
                        {
                            size++;
                            fullSize++;
                        }

                    if (radioButtonCustom.Checked)
                        size = Convert.ToInt32(textBoxCount.Text);

                    ReadCSV(size, fullSize);
                }
            }
            else
                MessageBox.Show("Application not connected to any server", "Error PRocessing Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ReadCSV(int size, int fullSize)
        {
            List<string> firstNameList = new List<string>();
            List<string> lastNameList = new List<string>();

            try
            {
                using (SqlConnection cnn = new SqlConnection(cs.ConStr))
                {
                    using (SqlCommand cmdCount = new SqlCommand("SELECT max(StudentID) FROM StudentTable", cnn))
                    {
                        cnn.Open();
                        StudentID = (int)cmdCount.ExecuteScalar();
                        cnn.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                StudentID = 0;
            }


            for (int i = 0; i < fullSize; i++)
            {
                string line = File.ReadLines(path).Skip(i).First();

                firstNameList.Add(line.Remove(line.IndexOf(",")));
                lastNameList.Add(line.Substring(line.IndexOf(",") + 1));
            }

            for (int i = 0; i < size; i++)
            {
                Random number = new Random();
                int index1 = number.Next(firstNameList.Count);
                int index2 = number.Next(lastNameList.Count);

                string email = "";
                switch (number.Next(4))
                {
                    case 0:
                        email = firstNameList[index1].ToLower() + "." + lastNameList[index2].ToLower() + "@gmail.com";
                        break;
                    case 1:
                        email = firstNameList[index1].ToLower() + "." + lastNameList[index2].ToLower() + "@hotmail.com";
                        break;
                    case 2:
                        email = firstNameList[index1].ToLower() + "." + lastNameList[index2].ToLower() + "@outlook.com";
                        break;
                    case 3:
                        email = firstNameList[index1].ToLower() + "." + lastNameList[index2].ToLower() + "@yahoo.com";
                        break;
                }

                int points = 0;
                int count = number.Next(1, 10);
                for (int z = 0; z < count; z++)
                {
                    points += 5;
                }

                string end = "'" + StudentID + "','" + firstNameList[index1] + "','" + lastNameList[index2] + "','" + email + "','" + points + "','" + number.Next(1, 8) + points + "','" + number.Next(1000, 10000) + "'";
                progressInfo.Add("INSERT(->StudentTable)/" + end);
                SQLs.Add("INSERT INTO StudentTable(StudentID, FirstName, LastName, Email, DailyPoints, TotalPoints, PinCode) VALUES(" + end + ")");

                Task.Delay(TimeSpan.FromSeconds(0.01)).Wait();

                StudentID++;
            }
            Form ProgressForm = new ProgressForm(cs.ConStr, SQLs.Count, cs);
            ProgressForm.Show();
        }

        private void ReadCSVTest(int size, int fullSize)
        {
            List<string> dataLine = new List<string>();
            Random number = new Random();

            for (int i = 0; i < fullSize; i++)
            {
                string line = File.ReadLines(path).Skip(i).First();
                dataLine.Add(line);
            }

            int dataCount = 1;
            string s = dataLine[0];
            for (int i = 0; i < s.Length; i++)
                if (s[i] == ',')
                    dataCount++;

            List<int> VarPos = new List<int>();
            string cmdVar = cmdLine.Remove(0, cmdLine.IndexOf("VALUES") + 6);
            while (cmdVar.Contains(","))
            {

                int p = cmdVar.IndexOf(",");



                cmdVar = cmdVar.Remove(cmdVar.IndexOf(","), 1);



                VarPos.Add(cmdVar.IndexOf(","));
            }

            for (int i = 0; i < size; i++)
            {
                int index = number.Next(dataLine.Count);
                string line = dataLine[index];

                for (int y = 0; y < dataCount; y++)
                {
                    cmdVar = cmdLine.Substring(0, VarPos[y]);
                }
            }

            try
            {
                SqlConnection cnn = new SqlConnection(cs.ConStr);
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = cmdLine;

                cmd.ExecuteNonQuery();
                cnn.Close();

                StudentID++;
                Task.Delay(TimeSpan.FromSeconds(0.1)).Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonTable_Click(object sender, EventArgs e)
        {
            if(cs != null)
            {
                Form Form;
                if(comboBox.SelectedIndex == 1)
                    Form = new RuleForm(cs);
                else
                    Form = new StudentList(cs);

                Form.Show();
            }
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            string fileOpen = "";
            using (OpenFileDialog OpenFile = new OpenFileDialog())
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                    fileOpen = OpenFile.FileName;
            }

            string fileSave = "";
            using (OpenFileDialog OpenFile = new OpenFileDialog())
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                    fileSave = OpenFile.FileName;
            }

            int counter = 0;
            using (var reader = File.OpenText(fileOpen))
                while (reader.ReadLine() != null)
                {
                    Random number = new Random();

                    string line = File.ReadLines(fileOpen).Skip(counter).First();
                    counter++;

                    string email = "";
                    switch (number.Next(4))
                    {
                        case 0:
                            email = line.Remove(line.IndexOf(",")).ToLower() + "." + line.Substring(line.IndexOf(",") + 1).ToLower() + "@gmail.com";
                            break;
                        case 1:
                            email = line.Remove(line.IndexOf(",")).ToLower() + "." + line.Substring(line.IndexOf(",") + 1).ToLower() + "@hotmail.com";
                            break;
                        case 2:
                            email = line.Remove(line.IndexOf(",")).ToLower() + "." + line.Substring(line.IndexOf(",") + 1).ToLower() + "@outlook.com";
                            break;
                        case 3:
                            email = line.Remove(line.IndexOf(",")).ToLower() + "." + line.Substring(line.IndexOf(",") + 1).ToLower() + "@yahoo.com";
                            break;
                    }

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(email);
                    File.AppendAllText(fileSave, sb.ToString());
                }
            MessageBox.Show("Finished generating " + counter.ToString() + " emails.");
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Clear all tables (4) from SQL database?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                cs.ClearAll();
        }

        private void ButtonStandard_Click(object sender, EventArgs e)
        {
            textBoxCommandLine.Text = "INSERT INTO StudentTable(StudentID, FirstName, LastName, Email, DailyPoints, TotalPoints, PinCode)                                                                                                                                            VALUES('StudentID','FirstName','Lastname','Email', 'DailyPoints','TotalPoints','PinCode')";
        }
    }
}
