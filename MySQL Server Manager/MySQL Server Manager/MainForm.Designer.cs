namespace MySQL_Server_Manager
{
    partial class MainForm
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCommandLine = new System.Windows.Forms.TextBox();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonFull = new System.Windows.Forms.RadioButton();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStandard1 = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelc = new System.Windows.Forms.Label();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(711, 28);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(160, 37);
            this.buttonOpenFile.TabIndex = 9;
            this.buttonOpenFile.Text = "Select File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // labelFile
            // 
            this.labelFile.Location = new System.Drawing.Point(29, 36);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(600, 20);
            this.labelFile.TabIndex = 9;
            this.labelFile.Text = "filedialog";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "DML query:";
            // 
            // textBoxCommandLine
            // 
            this.textBoxCommandLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCommandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommandLine.Location = new System.Drawing.Point(38, 199);
            this.textBoxCommandLine.Multiline = true;
            this.textBoxCommandLine.Name = "textBoxCommandLine";
            this.textBoxCommandLine.Size = new System.Drawing.Size(821, 234);
            this.textBoxCommandLine.TabIndex = 14;
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(33, 73);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(169, 24);
            this.radioButtonCustom.TabIndex = 13;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Custom generation";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonFull
            // 
            this.radioButtonFull.AutoSize = true;
            this.radioButtonFull.Location = new System.Drawing.Point(33, 112);
            this.radioButtonFull.Name = "radioButtonFull";
            this.radioButtonFull.Size = new System.Drawing.Size(166, 24);
            this.radioButtonFull.TabIndex = 12;
            this.radioButtonFull.TabStop = true;
            this.radioButtonFull.Text = "Exploit full CSV file";
            this.radioButtonFull.UseVisualStyleBackColor = true;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(208, 72);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 26);
            this.textBoxCount.TabIndex = 11;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(711, 459);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(160, 37);
            this.buttonExport.TabIndex = 10;
            this.buttonExport.Text = "Generate";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(711, 73);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(160, 37);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect to SQL";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 253);
            this.label1.TabIndex = 16;
            // 
            // buttonStandard1
            // 
            this.buttonStandard1.Location = new System.Drawing.Point(31, 459);
            this.buttonStandard1.Name = "buttonStandard1";
            this.buttonStandard1.Size = new System.Drawing.Size(160, 37);
            this.buttonStandard1.TabIndex = 15;
            this.buttonStandard1.Text = "SQL Profile";
            this.buttonStandard1.UseVisualStyleBackColor = true;
            this.buttonStandard1.Click += new System.EventHandler(this.ButtonStandard_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.Location = new System.Drawing.Point(711, 119);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(160, 37);
            this.buttonTable.TabIndex = 17;
            this.buttonTable.Text = "View Table";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.ButtonTable_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(481, 121);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(221, 28);
            this.comboBox.TabIndex = 18;
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Location = new System.Drawing.Point(204, 114);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(0, 20);
            this.labelc.TabIndex = 19;
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(197, 459);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(160, 37);
            this.buttonEmail.TabIndex = 20;
            this.buttonEmail.Text = "Generate Email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(363, 459);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(160, 37);
            this.buttonClearAll.TabIndex = 21;
            this.buttonClearAll.Text = "Clear All Table";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 514);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.buttonTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonCustom);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.textBoxCommandLine);
            this.Controls.Add(this.buttonStandard1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.radioButtonFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Server Manager v1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonFull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCommandLine;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStandard1;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.Button buttonClearAll;
    }
}

