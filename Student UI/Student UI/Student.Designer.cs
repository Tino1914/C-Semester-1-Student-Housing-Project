namespace Student_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            listView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStudentInfo = new System.Windows.Forms.Button();
            this.buttonTaskComplete = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonSeeAllStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTask = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSetTask = new System.Windows.Forms.Button();
            this.comboBoxNature = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRemotePort = new System.Windows.Forms.TextBox();
            this.textBoxLocalPort = new System.Windows.Forms.TextBox();
            this.textBoxRemoteIP = new System.Windows.Forms.TextBox();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader4,
            columnHeader5,
            columnHeader6});
            listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listView.HideSelection = false;
            listView.Location = new System.Drawing.Point(16, 55);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(382, 307);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Task";
            this.columnHeader6.Width = 110;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(16, 128);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(764, 112);
            this.textBoxDescription.TabIndex = 2;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(112, 42);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(258, 28);
            this.comboBoxName.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(596, 40);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(186, 72);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Weekly Tasks";
            // 
            // buttonStudentInfo
            // 
            this.buttonStudentInfo.Location = new System.Drawing.Point(432, 380);
            this.buttonStudentInfo.Name = "buttonStudentInfo";
            this.buttonStudentInfo.Size = new System.Drawing.Size(386, 38);
            this.buttonStudentInfo.TabIndex = 8;
            this.buttonStudentInfo.Text = "See student info";
            this.buttonStudentInfo.UseVisualStyleBackColor = true;
            this.buttonStudentInfo.Click += new System.EventHandler(this.ButtonStudentInfo_Click);
            // 
            // buttonTaskComplete
            // 
            this.buttonTaskComplete.Location = new System.Drawing.Point(16, 380);
            this.buttonTaskComplete.Name = "buttonTaskComplete";
            this.buttonTaskComplete.Size = new System.Drawing.Size(386, 38);
            this.buttonTaskComplete.TabIndex = 10;
            this.buttonTaskComplete.Text = "Task Complete";
            this.buttonTaskComplete.UseVisualStyleBackColor = true;
            this.buttonTaskComplete.Click += new System.EventHandler(this.ButtonTaskComplete_Click);
            // 
            // buttonRules
            // 
            this.buttonRules.Location = new System.Drawing.Point(431, 22);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(386, 38);
            this.buttonRules.TabIndex = 11;
            this.buttonRules.Text = "Rule Book";
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.ButtonRules_Click);
            // 
            // buttonSeeAllStudent
            // 
            this.buttonSeeAllStudent.Location = new System.Drawing.Point(432, 71);
            this.buttonSeeAllStudent.Name = "buttonSeeAllStudent";
            this.buttonSeeAllStudent.Size = new System.Drawing.Size(386, 38);
            this.buttonSeeAllStudent.TabIndex = 19;
            this.buttonSeeAllStudent.Text = "See All Student";
            this.buttonSeeAllStudent.UseVisualStyleBackColor = true;
            this.buttonSeeAllStudent.Click += new System.EventHandler(this.ButtonSeeAllStudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTask);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxCategory);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonSetTask);
            this.groupBox2.Controls.Add(this.comboBoxName);
            this.groupBox2.Location = new System.Drawing.Point(432, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 242);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Task:";
            // 
            // comboBoxTask
            // 
            this.comboBoxTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTask.FormattingEnabled = true;
            this.comboBoxTask.Location = new System.Drawing.Point(112, 127);
            this.comboBoxTask.Name = "comboBoxTask";
            this.comboBoxTask.Size = new System.Drawing.Size(258, 28);
            this.comboBoxTask.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Task:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(112, 88);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(258, 28);
            this.comboBoxCategory.TabIndex = 15;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name:";
            // 
            // buttonSetTask
            // 
            this.buttonSetTask.Location = new System.Drawing.Point(109, 179);
            this.buttonSetTask.Name = "buttonSetTask";
            this.buttonSetTask.Size = new System.Drawing.Size(261, 38);
            this.buttonSetTask.TabIndex = 14;
            this.buttonSetTask.Text = "Set Task";
            this.buttonSetTask.UseVisualStyleBackColor = true;
            this.buttonSetTask.Click += new System.EventHandler(this.ButtonSetTask_Click);
            // 
            // comboBoxNature
            // 
            this.comboBoxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNature.FormattingEnabled = true;
            this.comboBoxNature.Location = new System.Drawing.Point(81, 40);
            this.comboBoxNature.Name = "comboBoxNature";
            this.comboBoxNature.Size = new System.Drawing.Size(259, 28);
            this.comboBoxNature.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonSubmit);
            this.groupBox3.Controls.Add(this.comboBoxNature);
            this.groupBox3.Controls.Add(this.textBoxDescription);
            this.groupBox3.Location = new System.Drawing.Point(16, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(796, 256);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Complaint Box:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nature:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Description:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(592, 48);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(186, 72);
            this.buttonConnect.TabIndex = 21;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBoxRemotePort);
            this.groupBox4.Controls.Add(this.textBoxLocalPort);
            this.groupBox4.Controls.Add(this.textBoxRemoteIP);
            this.groupBox4.Controls.Add(this.textBoxLocalIP);
            this.groupBox4.Controls.Add(this.buttonConnect);
            this.groupBox4.Location = new System.Drawing.Point(16, 709);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(796, 153);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Local Port:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Local IP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Remote Port:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Remote IP:";
            // 
            // textBoxRemotePort
            // 
            this.textBoxRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxRemotePort.Location = new System.Drawing.Point(128, 85);
            this.textBoxRemotePort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRemotePort.Name = "textBoxRemotePort";
            this.textBoxRemotePort.Size = new System.Drawing.Size(166, 26);
            this.textBoxRemotePort.TabIndex = 25;
            // 
            // textBoxLocalPort
            // 
            this.textBoxLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxLocalPort.Location = new System.Drawing.Point(404, 88);
            this.textBoxLocalPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLocalPort.Name = "textBoxLocalPort";
            this.textBoxLocalPort.Size = new System.Drawing.Size(166, 26);
            this.textBoxLocalPort.TabIndex = 23;
            // 
            // textBoxRemoteIP
            // 
            this.textBoxRemoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxRemoteIP.Location = new System.Drawing.Point(128, 45);
            this.textBoxRemoteIP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRemoteIP.Name = "textBoxRemoteIP";
            this.textBoxRemoteIP.Size = new System.Drawing.Size(166, 26);
            this.textBoxRemoteIP.TabIndex = 24;
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxLocalIP.Location = new System.Drawing.Point(404, 48);
            this.textBoxLocalIP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.Size = new System.Drawing.Size(166, 26);
            this.textBoxLocalIP.TabIndex = 22;
            // 
            // timerDate
            // 
            this.timerDate.Interval = 10000;
            this.timerDate.Tick += new System.EventHandler(this.TimerDate_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 877);
            this.Controls.Add(this.buttonSeeAllStudent);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.buttonTaskComplete);
            this.Controls.Add(this.buttonStudentInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(listView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student UI";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStudentInfo;
        private System.Windows.Forms.Button buttonTaskComplete;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSetTask;
        private System.Windows.Forms.ComboBox comboBoxNature;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRemotePort;
        private System.Windows.Forms.TextBox textBoxLocalPort;
        private System.Windows.Forms.TextBox textBoxRemoteIP;
        private System.Windows.Forms.TextBox textBoxLocalIP;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonSeeAllStudent;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ComboBox comboBoxTask;
        private System.Windows.Forms.ComboBox comboBoxName;
        public static System.Windows.Forms.ListView listView;
    }
}

