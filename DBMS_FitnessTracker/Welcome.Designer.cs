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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.masterToolStripMenuItem,
            this.dailyLogToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(771, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.goalsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 22);
            this.toolStripMenuItem1.Text = "User page";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityGoalsToolStripMenuItem,
            this.dietGoalsToolStripMenuItem});
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.goalsToolStripMenuItem.Text = "Goals";
            // 
            // activityGoalsToolStripMenuItem
            // 
            this.activityGoalsToolStripMenuItem.Name = "activityGoalsToolStripMenuItem";
            this.activityGoalsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.activityGoalsToolStripMenuItem.Text = "Activity goals";
            this.activityGoalsToolStripMenuItem.Click += new System.EventHandler(this.activityGoalsToolStripMenuItem_Click);
            // 
            // dietGoalsToolStripMenuItem
            // 
            this.dietGoalsToolStripMenuItem.Name = "dietGoalsToolStripMenuItem";
            this.dietGoalsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dietGoalsToolStripMenuItem.Text = "Diet goals";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dietToolStripMenuItem,
            this.activityToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // dietToolStripMenuItem
            // 
            this.dietToolStripMenuItem.Name = "dietToolStripMenuItem";
            this.dietToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.dietToolStripMenuItem.Text = "Diet ";

            this.dietToolStripMenuItem.Click += new System.EventHandler(this.dietToolStripMenuItem_Click);

            
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click_1);
            // 
            // dailyLogToolStripMenuItem
            // 
            this.dailyLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityChartToolStripMenuItem,
            this.dietChartToolStripMenuItem});
            this.dailyLogToolStripMenuItem.Name = "dailyLogToolStripMenuItem";
            this.dailyLogToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.dailyLogToolStripMenuItem.Text = "Daily Log";
            // 
            // activityChartToolStripMenuItem
            // 
            this.activityChartToolStripMenuItem.Name = "activityChartToolStripMenuItem";
            this.activityChartToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.activityChartToolStripMenuItem.Text = "Activity chart ";
            this.activityChartToolStripMenuItem.Click += new System.EventHandler(this.activityChartToolStripMenuItem_Click_1);
            // 
            // dietChartToolStripMenuItem
            // 
            this.dietChartToolStripMenuItem.Name = "dietChartToolStripMenuItem";
            this.dietChartToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.dietChartToolStripMenuItem.Text = "Diet Chart ";
            this.dietChartToolStripMenuItem.Click += new System.EventHandler(this.dietChartToolStripMenuItem_Click_1);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem,
            this.cumulativeReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dailyReportToolStripMenuItem.Text = "Daily report";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // cumulativeReportToolStripMenuItem
            // 
            this.cumulativeReportToolStripMenuItem.Name = "cumulativeReportToolStripMenuItem";
            this.cumulativeReportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cumulativeReportToolStripMenuItem.Text = "Cumulative report ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 377);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Welcome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panel1;
    }
}

