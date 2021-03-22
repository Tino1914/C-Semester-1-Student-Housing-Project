namespace Admin_UI
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
            this.listViewComplaints = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerMessage = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRemotePort = new System.Windows.Forms.TextBox();
            this.textBoxLocalPort = new System.Windows.Forms.TextBox();
            this.textBoxRemoteIP = new System.Windows.Forms.TextBox();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.btnComplaint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemvoeRule = new System.Windows.Forms.Button();
            this.btnCreateNewRule = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSeeAllStudent = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTotalTasks = new System.Windows.Forms.Label();
            this.labelComplaints = new System.Windows.Forms.Label();
            this.labelStudents = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewComplaints
            // 
            this.listViewComplaints.BackColor = System.Drawing.Color.White;
            this.listViewComplaints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewComplaints.ForeColor = System.Drawing.Color.Black;
            this.listViewComplaints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewComplaints.HideSelection = false;
            this.listViewComplaints.Location = new System.Drawing.Point(5, 15);
            this.listViewComplaints.Name = "listViewComplaints";
            this.listViewComplaints.Size = new System.Drawing.Size(770, 244);
            this.listViewComplaints.TabIndex = 3;
            this.listViewComplaints.UseCompatibleStateImageBehavior = false;
            this.listViewComplaints.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nature";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 330;
            // 
            // timerMessage
            // 
            this.timerMessage.Interval = 500;
            this.timerMessage.Tick += new System.EventHandler(this.TimerMessage_Tick);
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
            this.groupBox4.Location = new System.Drawing.Point(16, 707);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(796, 155);
            this.groupBox4.TabIndex = 44;
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
            // btnComplaint
            // 
            this.btnComplaint.Location = new System.Drawing.Point(3, 268);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(303, 54);
            this.btnComplaint.TabIndex = 29;
            this.btnComplaint.Text = "View Complaint";
            this.btnComplaint.UseVisualStyleBackColor = true;
            this.btnComplaint.Click += new System.EventHandler(this.BtnComplaint_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 366);
            this.tabControl1.TabIndex = 46;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listViewComplaints);
            this.tabPage1.Controls.Add(this.btnComplaint);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Issue Log";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnRemvoeRule);
            this.tabPage2.Controls.Add(this.btnCreateNewRule);
            this.tabPage2.Controls.Add(this.btnModify);
            this.tabPage2.Controls.Add(this.listView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rules";
            // 
            // btnRemvoeRule
            // 
            this.btnRemvoeRule.Location = new System.Drawing.Point(461, 267);
            this.btnRemvoeRule.Name = "btnRemvoeRule";
            this.btnRemvoeRule.Size = new System.Drawing.Size(223, 54);
            this.btnRemvoeRule.TabIndex = 47;
            this.btnRemvoeRule.Text = "Remove Rule";
            this.btnRemvoeRule.UseVisualStyleBackColor = true;
            this.btnRemvoeRule.Click += new System.EventHandler(this.BtnRemoveRule_Click);
            // 
            // btnCreateNewRule
            // 
            this.btnCreateNewRule.Location = new System.Drawing.Point(232, 267);
            this.btnCreateNewRule.Name = "btnCreateNewRule";
            this.btnCreateNewRule.Size = new System.Drawing.Size(223, 54);
            this.btnCreateNewRule.TabIndex = 46;
            this.btnCreateNewRule.Text = "Add New";
            this.btnCreateNewRule.UseVisualStyleBackColor = true;
            this.btnCreateNewRule.Click += new System.EventHandler(this.BtnCreateNewRule_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(3, 267);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(223, 54);
            this.btnModify.TabIndex = 44;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(6, 15);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(768, 244);
            this.listView.TabIndex = 53;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rule No.";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Rule Description";
            this.columnHeader5.Width = 425;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSeeAllStudent);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonAddStudent);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Location = new System.Drawing.Point(16, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 295);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // buttonSeeAllStudent
            // 
            this.buttonSeeAllStudent.Location = new System.Drawing.Point(112, 235);
            this.buttonSeeAllStudent.Name = "buttonSeeAllStudent";
            this.buttonSeeAllStudent.Size = new System.Drawing.Size(261, 39);
            this.buttonSeeAllStudent.TabIndex = 19;
            this.buttonSeeAllStudent.Text = "See All Student";
            this.buttonSeeAllStudent.UseVisualStyleBackColor = true;
            this.buttonSeeAllStudent.Click += new System.EventHandler(this.ButtonSeeAllStudent_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(115, 131);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(255, 26);
            this.textBoxEmail.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(115, 84);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(255, 26);
            this.textBoxLastName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Name:";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(112, 181);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(261, 39);
            this.buttonAddStudent.TabIndex = 14;
            this.buttonAddStudent.Text = "Add new student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(115, 42);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(255, 26);
            this.textBoxFirstName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Students:";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(112, 235);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(261, 39);
            this.buttonChange.TabIndex = 19;
            this.buttonChange.Text = "Change Password";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCompleted);
            this.groupBox2.Controls.Add(this.labelProgress);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.labelTotalTasks);
            this.groupBox2.Controls.Add(this.labelComplaints);
            this.groupBox2.Controls.Add(this.labelStudents);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonChange);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(430, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 295);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info Overview";
            // 
            // labelCompleted
            // 
            this.labelCompleted.AutoSize = true;
            this.labelCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompleted.Location = new System.Drawing.Point(311, 190);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(19, 20);
            this.labelCompleted.TabIndex = 28;
            this.labelCompleted.Text = "--";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(311, 157);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(19, 20);
            this.labelProgress.TabIndex = 27;
            this.labelProgress.Text = "--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(87, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Completed:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Tasks in Progress:";
            // 
            // labelTotalTasks
            // 
            this.labelTotalTasks.AutoSize = true;
            this.labelTotalTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTasks.Location = new System.Drawing.Point(306, 118);
            this.labelTotalTasks.Name = "labelTotalTasks";
            this.labelTotalTasks.Size = new System.Drawing.Size(31, 29);
            this.labelTotalTasks.TabIndex = 24;
            this.labelTotalTasks.Text = "--";
            // 
            // labelComplaints
            // 
            this.labelComplaints.AutoSize = true;
            this.labelComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplaints.Location = new System.Drawing.Point(306, 77);
            this.labelComplaints.Name = "labelComplaints";
            this.labelComplaints.Size = new System.Drawing.Size(31, 29);
            this.labelComplaints.TabIndex = 23;
            this.labelComplaints.Text = "--";
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudents.Location = new System.Drawing.Point(306, 36);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(31, 29);
            this.labelStudents.TabIndex = 22;
            this.labelStudents.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Active Students:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Complaints this week:";
            // 
            // timerInfo
            // 
            this.timerInfo.Tick += new System.EventHandler(this.TimerInfo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(828, 877);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin UI";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewComplaints;
        private System.Windows.Forms.Timer timerMessage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRemotePort;
        private System.Windows.Forms.TextBox textBoxLocalPort;
        private System.Windows.Forms.TextBox textBoxRemoteIP;
        private System.Windows.Forms.TextBox textBoxLocalIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button btnComplaint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSeeAllStudent;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateNewRule;
        private System.Windows.Forms.Button btnRemvoeRule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTotalTasks;
        private System.Windows.Forms.Label labelComplaints;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Timer timerInfo;
    }
}

