namespace DBMS_FitnessTracker
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityGoalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dietGoalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dietChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumulativeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to FT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.masterToolStripMenuItem,
            this.dailyLogToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.goalsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 29);
            this.toolStripMenuItem1.Text = "User page";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityGoalsToolStripMenuItem,
            this.dietGoalsToolStripMenuItem});
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.goalsToolStripMenuItem.Text = "Goals";
            // 
            // activityGoalsToolStripMenuItem
            // 
            this.activityGoalsToolStripMenuItem.Name = "activityGoalsToolStripMenuItem";
            this.activityGoalsToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.activityGoalsToolStripMenuItem.Text = "Activity goals";
            this.activityGoalsToolStripMenuItem.Click += new System.EventHandler(this.activityGoalsToolStripMenuItem_Click);
            // 
            // dietGoalsToolStripMenuItem
            // 
            this.dietGoalsToolStripMenuItem.Name = "dietGoalsToolStripMenuItem";
            this.dietGoalsToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.dietGoalsToolStripMenuItem.Text = "Diet goals";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dietToolStripMenuItem,
            this.activityToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // dietToolStripMenuItem
            // 
            this.dietToolStripMenuItem.Name = "dietToolStripMenuItem";
            this.dietToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.dietToolStripMenuItem.Text = "Diet ";
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click_1);
            // 
            // dailyLogToolStripMenuItem
            // 
            this.dailyLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityChartToolStripMenuItem,
            this.dietChartToolStripMenuItem});
            this.dailyLogToolStripMenuItem.Name = "dailyLogToolStripMenuItem";
            this.dailyLogToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.dailyLogToolStripMenuItem.Text = "Daily Log";
            // 
            // activityChartToolStripMenuItem
            // 
            this.activityChartToolStripMenuItem.Name = "activityChartToolStripMenuItem";
            this.activityChartToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.activityChartToolStripMenuItem.Text = "Activity chart ";
            this.activityChartToolStripMenuItem.Click += new System.EventHandler(this.activityChartToolStripMenuItem_Click);
            // 
            // dietChartToolStripMenuItem
            // 
            this.dietChartToolStripMenuItem.Name = "dietChartToolStripMenuItem";
            this.dietChartToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.dietChartToolStripMenuItem.Text = "Diet Chart ";
            this.dietChartToolStripMenuItem.Click += new System.EventHandler(this.dietChartToolStripMenuItem_Click_1);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem,
            this.cumulativeReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dailyReportToolStripMenuItem.Text = "Daily report";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // cumulativeReportToolStripMenuItem
            // 
            this.cumulativeReportToolStripMenuItem.Name = "cumulativeReportToolStripMenuItem";
            this.cumulativeReportToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cumulativeReportToolStripMenuItem.Text = "Cumulative report ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter User name :";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(318, 230);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(136, 47);
            this.login.TabIndex = 3;
            this.login.Text = "Log IN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(405, 149);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 26);
            this.user.TabIndex = 4;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(318, 313);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(146, 42);
            this.logout.TabIndex = 5;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.user);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Welcome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityGoalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dietGoalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dietChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumulativeReportToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button logout;
    }
}

