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
            this.sethours = new System.Windows.Forms.Label();
            this.actdur = new System.Windows.Forms.TextBox();
            this.setacti = new System.Windows.Forms.GroupBox();
            this.addact = new System.Windows.Forms.Button();
            this.goal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SetUrGoal = new System.Windows.Forms.CheckedListBox();
            this.setacti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Activity Name";
            // 
            // actname
            // 
            this.actname.FormattingEnabled = true;
            this.actname.Location = new System.Drawing.Point(143, 62);
            this.actname.Name = "actname";
            this.actname.Size = new System.Drawing.Size(121, 27);
            this.actname.TabIndex = 16;
            this.actname.SelectedIndexChanged += new System.EventHandler(this.actname_SelectedIndexChanged);
            // 
            // sethours
            // 
            this.sethours.AutoSize = true;
            this.sethours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sethours.Location = new System.Drawing.Point(9, 145);
            this.sethours.Name = "sethours";
            this.sethours.Size = new System.Drawing.Size(103, 16);
            this.sethours.TabIndex = 20;
            this.sethours.Text = "Duration (in min)";
            // 
            // actdur
            // 
            this.actdur.Location = new System.Drawing.Point(143, 134);
            this.actdur.Name = "actdur";
            this.actdur.Size = new System.Drawing.Size(100, 26);
            this.actdur.TabIndex = 21;
            this.actdur.TextChanged += new System.EventHandler(this.actdur_TextChanged);
            // 
            // setacti
            // 
            this.setacti.Controls.Add(this.addact);
            this.setacti.Controls.Add(this.sethours);
            this.setacti.Controls.Add(this.actdur);
            this.setacti.Controls.Add(this.label2);
            this.setacti.Controls.Add(this.actname);
            this.setacti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setacti.Location = new System.Drawing.Point(15, 31);
            this.setacti.Name = "setacti";
            this.setacti.Size = new System.Drawing.Size(321, 275);
            this.setacti.TabIndex = 22;
            this.setacti.TabStop = false;
            this.setacti.Text = "Add activity to your Goal";
            // 
            // addact
            // 
            this.addact.Location = new System.Drawing.Point(106, 203);
            this.addact.Name = "addact";
            this.addact.Size = new System.Drawing.Size(87, 37);
            this.addact.TabIndex = 0;
            this.addact.Text = "ADD";
            this.addact.UseVisualStyleBackColor = true;
            this.addact.Click += new System.EventHandler(this.addact_Click);
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goal.Location = new System.Drawing.Point(383, 43);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(154, 19);
            this.goal.TabIndex = 23;
            this.goal.Text = "YOUR DAILY GOAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "To edit your goal,";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(171, 340);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 18);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Me";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SetUrGoal
            // 
            this.SetUrGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetUrGoal.FormattingEnabled = true;
            this.SetUrGoal.Location = new System.Drawing.Point(387, 77);
            this.SetUrGoal.Name = "SetUrGoal";
            this.SetUrGoal.Size = new System.Drawing.Size(308, 229);
            this.SetUrGoal.TabIndex = 27;
            this.SetUrGoal.SelectedIndexChanged += new System.EventHandler(this.SetUrGoal_SelectedIndexChanged);
            // 
            // SetActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 377);
            this.Controls.Add(this.SetUrGoal);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.setacti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label sethours;
        private System.Windows.Forms.TextBox actdur;
        private System.Windows.Forms.GroupBox setacti;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckedListBox SetUrGoal;
        private System.Windows.Forms.Button addact;
    }
}