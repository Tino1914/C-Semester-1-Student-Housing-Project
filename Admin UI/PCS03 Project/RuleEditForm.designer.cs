namespace Admin_UI
{
    partial class RuleEditForm
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
            this.tbRule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModifyRule = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRule
            // 
            this.tbRule.Location = new System.Drawing.Point(112, 20);
            this.tbRule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRule.Name = "tbRule";
            this.tbRule.Size = new System.Drawing.Size(42, 26);
            this.tbRule.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Create rule";
            // 
            // tbModifyRule
            // 
            this.tbModifyRule.Location = new System.Drawing.Point(25, 63);
            this.tbModifyRule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbModifyRule.Multiline = true;
            this.tbModifyRule.Name = "tbModifyRule";
            this.tbModifyRule.Size = new System.Drawing.Size(608, 253);
            this.tbModifyRule.TabIndex = 47;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(303, 54);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RuleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 404);
            this.Controls.Add(this.tbRule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbModifyRule);
            this.Controls.Add(this.btnSave);
            this.Name = "RuleEditForm";
            this.Text = "Rule Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModifyRule;
        private System.Windows.Forms.Button btnSave;
    }
}