namespace MySQL_Server_Manager
{
    partial class ProgressForm
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
            this.labeler = new System.Windows.Forms.Label();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.timerSub = new System.Windows.Forms.Timer(this.components);
            this.progressBarSub = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labeler
            // 
            this.labeler.AutoSize = true;
            this.labeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeler.Location = new System.Drawing.Point(45, 152);
            this.labeler.Name = "labeler";
            this.labeler.Size = new System.Drawing.Size(156, 20);
            this.labeler.TabIndex = 0;
            this.labeler.Text = "Processing Data...";
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(45, 66);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(700, 23);
            this.progressBarMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarMain.TabIndex = 1;
            // 
            // timerSub
            // 
            this.timerSub.Tick += new System.EventHandler(this.TimerSub_Tick);
            // 
            // progressBarSub
            // 
            this.progressBarSub.Location = new System.Drawing.Point(45, 175);
            this.progressBarSub.Name = "progressBarSub";
            this.progressBarSub.Size = new System.Drawing.Size(700, 23);
            this.progressBarSub.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sending Data...";
            // 
            // labelMain
            // 
            this.labelMain.Location = new System.Drawing.Point(45, 102);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(700, 20);
            this.labelMain.TabIndex = 5;
            this.labelMain.Text = "Progress task...";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSub
            // 
            this.labelSub.Location = new System.Drawing.Point(45, 211);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(700, 20);
            this.labelSub.TabIndex = 6;
            this.labelSub.Text = "Progress task...";
            // 
            // timerLabel
            // 
            this.timerLabel.Interval = 10;
            this.timerLabel.Tick += new System.EventHandler(this.TimerLabel_Tick);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarSub);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.labeler);
            this.Name = "ProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Executing Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeler;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Timer timerSub;
        private System.Windows.Forms.ProgressBar progressBarSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Timer timerLabel;
    }
}