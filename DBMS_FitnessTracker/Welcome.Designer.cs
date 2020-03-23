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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to FT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.masterToolStripMenuItem,
            this.dailyLogToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(711, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.goalsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.toolStripMenuItem1.Text = "User page";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityGoalsToolStripMenuItem,
            this.dietGoalsToolStripMenuItem});
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.goalsToolStripMenuItem.Text = "Goals";
            // 
            // activityGoalsToolStripMenuItem
            // 
            this.activityGoalsToolStripMenuItem.Name = "activityGoalsToolStripMenuItem";
            this.activityGoalsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.activityGoalsToolStripMenuItem.Text = "Activity goals";
            // 
            // dietGoalsToolStripMenuItem
            // 
            this.dietGoalsToolStripMenuItem.Name = "dietGoalsToolStripMenuItem";
            this.dietGoalsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.dietGoalsToolStripMenuItem.Text = "Diet goals";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dietToolStripMenuItem,
            this.activityToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // dietToolStripMenuItem
            // 
            this.dietToolStripMenuItem.Name = "dietToolStripMenuItem";
            this.dietToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.dietToolStripMenuItem.Text = "Diet ";
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.activityToolStripMenuItem.Text = "Activity";
            // 
            // dailyLogToolStripMenuItem
            // 
            this.dailyLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityChartToolStripMenuItem,
            this.dietChartToolStripMenuItem});
            this.dailyLogToolStripMenuItem.Name = "dailyLogToolStripMenuItem";
            this.dailyLogToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.dailyLogToolStripMenuItem.Text = "Daily Log";
            // 
            // activityChartToolStripMenuItem
            // 
            this.activityChartToolStripMenuItem.Name = "activityChartToolStripMenuItem";
            this.activityChartToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.activityChartToolStripMenuItem.Text = "Activity chart ";
            // 
            // dietChartToolStripMenuItem
            // 
            this.dietChartToolStripMenuItem.Name = "dietChartToolStripMenuItem";
            this.dietChartToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dietChartToolStripMenuItem.Text = "Diet Chart ";
            this.dietChartToolStripMenuItem.Click += new System.EventHandler(this.dietChartToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem,
            this.cumulativeReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.dailyReportToolStripMenuItem.Text = "Daily report";
            // 
            // cumulativeReportToolStripMenuItem
            // 
            this.cumulativeReportToolStripMenuItem.Name = "cumulativeReportToolStripMenuItem";
            this.cumulativeReportToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.cumulativeReportToolStripMenuItem.Text = "Cumulative report ";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Welcome";
            this.Text = "Form1";
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
    }
}

