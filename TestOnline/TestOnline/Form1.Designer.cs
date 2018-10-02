namespace TestOnline
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpFunciton = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpReport = new System.Windows.Forms.ToolStripMenuItem();
            this.markViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1ForHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.tpFunciton,
            this.tpReport,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tpFunciton
            // 
            this.tpFunciton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionToolStripMenuItem,
            this.manageQuestionToolStripMenuItem,
            this.manageExamToolStripMenuItem});
            this.tpFunciton.Enabled = false;
            this.tpFunciton.Name = "tpFunciton";
            this.tpFunciton.Size = new System.Drawing.Size(66, 20);
            this.tpFunciton.Text = "Function";
            // 
            // addQuestionToolStripMenuItem
            // 
            this.addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            this.addQuestionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addQuestionToolStripMenuItem.Text = "AddQuestion";
            this.addQuestionToolStripMenuItem.Click += new System.EventHandler(this.addQuestionToolStripMenuItem_Click);
            // 
            // manageQuestionToolStripMenuItem
            // 
            this.manageQuestionToolStripMenuItem.Name = "manageQuestionToolStripMenuItem";
            this.manageQuestionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageQuestionToolStripMenuItem.Text = "Manage Question";
            this.manageQuestionToolStripMenuItem.Click += new System.EventHandler(this.manageQuestionToolStripMenuItem_Click);
            // 
            // manageExamToolStripMenuItem
            // 
            this.manageExamToolStripMenuItem.Name = "manageExamToolStripMenuItem";
            this.manageExamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageExamToolStripMenuItem.Text = "Manage Exam";
            // 
            // tpReport
            // 
            this.tpReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markViewToolStripMenuItem,
            this.studentViewToolStripMenuItem});
            this.tpReport.Enabled = false;
            this.tpReport.Name = "tpReport";
            this.tpReport.Size = new System.Drawing.Size(54, 20);
            this.tpReport.Text = "Report";
            // 
            // markViewToolStripMenuItem
            // 
            this.markViewToolStripMenuItem.Name = "markViewToolStripMenuItem";
            this.markViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markViewToolStripMenuItem.Text = "Mark View";
            // 
            // studentViewToolStripMenuItem
            // 
            this.studentViewToolStripMenuItem.Name = "studentViewToolStripMenuItem";
            this.studentViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentViewToolStripMenuItem.Text = "Student View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1ForHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // f1ForHelpToolStripMenuItem
            // 
            this.f1ForHelpToolStripMenuItem.Name = "f1ForHelpToolStripMenuItem";
            this.f1ForHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.f1ForHelpToolStripMenuItem.Text = "F1 for Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 491);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tpFunciton;
        private System.Windows.Forms.ToolStripMenuItem addQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tpReport;
        private System.Windows.Forms.ToolStripMenuItem markViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f1ForHelpToolStripMenuItem;
    }
}

