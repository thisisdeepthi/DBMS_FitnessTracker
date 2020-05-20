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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddDiet = new System.Windows.Forms.Button();
            this.DietGoal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddDietGoal = new System.Windows.Forms.RichTextBox();
            this.setacti.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.actname.Location = new System.Drawing.Point(122, 63);
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
            this.actdur.Location = new System.Drawing.Point(122, 135);
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
            this.setacti.Size = new System.Drawing.Size(272, 274);
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
            this.goal.Location = new System.Drawing.Point(523, 31);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(231, 19);
            this.goal.TabIndex = 23;
            this.goal.Text = "YOUR DAILY ACTIVITY GOAL";
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
            this.SetUrGoal.Location = new System.Drawing.Point(527, 58);
            this.SetUrGoal.Name = "SetUrGoal";
            this.SetUrGoal.Size = new System.Drawing.Size(232, 137);
            this.SetUrGoal.TabIndex = 27;
            this.SetUrGoal.SelectedIndexChanged += new System.EventHandler(this.SetUrGoal_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddDiet);
            this.groupBox1.Controls.Add(this.DietGoal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(306, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 196);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diet Goal";
            // 
            // AddDiet
            // 
            this.AddDiet.Location = new System.Drawing.Point(55, 124);
            this.AddDiet.Name = "AddDiet";
            this.AddDiet.Size = new System.Drawing.Size(84, 39);
            this.AddDiet.TabIndex = 2;
            this.AddDiet.Text = "ADD";
            this.AddDiet.UseVisualStyleBackColor = true;
            this.AddDiet.Click += new System.EventHandler(this.AddDiet_Click);
            // 
            // DietGoal
            // 
            this.DietGoal.Location = new System.Drawing.Point(46, 71);
            this.DietGoal.Name = "DietGoal";
            this.DietGoal.Size = new System.Drawing.Size(100, 26);
            this.DietGoal.TabIndex = 1;
            this.DietGoal.TextChanged += new System.EventHandler(this.DietGoal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calories To Be Taken";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(523, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "YOUR DAILY DIET GOAL";
            // 
            // AddDietGoal
            // 
            this.AddDietGoal.Location = new System.Drawing.Point(527, 258);
            this.AddDietGoal.Name = "AddDietGoal";
            this.AddDietGoal.Size = new System.Drawing.Size(227, 100);
            this.AddDietGoal.TabIndex = 30;
            this.AddDietGoal.Text = "";
            // 
            // SetActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 377);
            this.Controls.Add(this.AddDietGoal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddDiet;
        private System.Windows.Forms.TextBox DietGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox AddDietGoal;
    }
}