namespace DBMS_FitnessTracker
{
    partial class SetActivity
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
            this.label2 = new System.Windows.Forms.Label();
            this.actname = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sethours = new System.Windows.Forms.Label();
            this.actdur = new System.Windows.Forms.TextBox();
            this.setacti = new System.Windows.Forms.GroupBox();
            this.goal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.finish = new System.Windows.Forms.Button();
            this.SetUrGoal = new System.Windows.Forms.CheckedListBox();
            this.addact = new System.Windows.Forms.Button();
            this.setacti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Activity Name";
            // 
            // actname
            // 
            this.actname.FormattingEnabled = true;
            this.actname.Location = new System.Drawing.Point(126, 76);
            this.actname.Name = "actname";
            this.actname.Size = new System.Drawing.Size(121, 21);
            this.actname.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sethours
            // 
            this.sethours.AutoSize = true;
            this.sethours.Location = new System.Drawing.Point(8, 83);
            this.sethours.Name = "sethours";
            this.sethours.Size = new System.Drawing.Size(71, 13);
            this.sethours.TabIndex = 20;
            this.sethours.Text = "Hours (in min)";
            // 
            // actdur
            // 
            this.actdur.Location = new System.Drawing.Point(122, 83);
            this.actdur.Name = "actdur";
            this.actdur.Size = new System.Drawing.Size(100, 20);
            this.actdur.TabIndex = 21;
            // 
            // setacti
            // 
            this.setacti.Controls.Add(this.addact);
            this.setacti.Controls.Add(this.sethours);
            this.setacti.Controls.Add(this.actdur);
            this.setacti.Location = new System.Drawing.Point(4, 39);
            this.setacti.Name = "setacti";
            this.setacti.Size = new System.Drawing.Size(267, 209);
            this.setacti.TabIndex = 22;
            this.setacti.TabStop = false;
            this.setacti.Text = "Add activity to your Goal";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(308, 30);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(125, 13);
            this.goal.TabIndex = 23;
            this.goal.Text = "Select your Today\'s Goal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "To edit your goal,";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(126, 255);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Me";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(429, 250);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 26;
            this.finish.Text = "FINISH";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // SetUrGoal
            // 
            this.SetUrGoal.FormattingEnabled = true;
            this.SetUrGoal.Location = new System.Drawing.Point(311, 68);
            this.SetUrGoal.Name = "SetUrGoal";
            this.SetUrGoal.Size = new System.Drawing.Size(162, 124);
            this.SetUrGoal.TabIndex = 27;
            this.SetUrGoal.SelectedIndexChanged += new System.EventHandler(this.SetUrGoal_SelectedIndexChanged);
            // 
            // addact
            // 
            this.addact.Location = new System.Drawing.Point(83, 136);
            this.addact.Name = "addact";
            this.addact.Size = new System.Drawing.Size(87, 37);
            this.addact.TabIndex = 0;
            this.addact.Text = "ADD";
            this.addact.UseVisualStyleBackColor = true;
            this.addact.Click += new System.EventHandler(this.addact_Click);
            // 
            // SetActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 296);
            this.Controls.Add(this.SetUrGoal);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.actname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setacti);
            this.Name = "SetActivity";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SetActivity_Load);
            this.setacti.ResumeLayout(false);
            this.setacti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox actname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sethours;
        private System.Windows.Forms.TextBox actdur;
        private System.Windows.Forms.GroupBox setacti;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.CheckedListBox SetUrGoal;
        private System.Windows.Forms.Button addact;
    }
}