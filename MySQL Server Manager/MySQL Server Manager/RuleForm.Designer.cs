namespace MySQL_Server_Manager
{
    partial class RuleForm
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
            this.btnRemvoeRule = new System.Windows.Forms.Button();
            this.btnCreateNewRule = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRemvoeRule
            // 
            this.btnRemvoeRule.Location = new System.Drawing.Point(470, 565);
            this.btnRemvoeRule.Name = "btnRemvoeRule";
            this.btnRemvoeRule.Size = new System.Drawing.Size(223, 54);
            this.btnRemvoeRule.TabIndex = 51;
            this.btnRemvoeRule.Text = "Remove Rule";
            this.btnRemvoeRule.UseVisualStyleBackColor = true;
            this.btnRemvoeRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // btnCreateNewRule
            // 
            this.btnCreateNewRule.Location = new System.Drawing.Point(241, 565);
            this.btnCreateNewRule.Name = "btnCreateNewRule";
            this.btnCreateNewRule.Size = new System.Drawing.Size(223, 54);
            this.btnCreateNewRule.TabIndex = 50;
            this.btnCreateNewRule.Text = "Add New";
            this.btnCreateNewRule.UseVisualStyleBackColor = true;
            this.btnCreateNewRule.Click += new System.EventHandler(this.btnCreateNewRule_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 565);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(223, 54);
            this.btnModify.TabIndex = 48;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1081, 544);
            this.listView.TabIndex = 52;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rule No.";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rule Description";
            this.columnHeader2.Width = 610;
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 629);
            this.Controls.Add(this.btnRemvoeRule);
            this.Controls.Add(this.btnCreateNewRule);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.listView);
            this.Name = "RuleForm";
            this.Text = "Rules Table";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemvoeRule;
        private System.Windows.Forms.Button btnCreateNewRule;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}