namespace DBMS_FitnessTracker
{
    partial class UserPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agebox = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.TextBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.ht = new System.Windows.Forms.NumericUpDown();
            this.wt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Updatenew = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agebox);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic details";
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(107, 73);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(159, 26);
            this.agebox.TabIndex = 9;
            this.agebox.Value = new System.DateTime(2000, 6, 16, 0, 0, 0, 0);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(107, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 8;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(107, 153);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(87, 24);
            this.female.TabIndex = 7;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(107, 121);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(68, 24);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(29, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(143, 83);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(144, 26);
            this.email.TabIndex = 11;
           
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(145, 38);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 26);
            this.phone.TabIndex = 10;
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Phone no";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.category);
            this.groupBox3.Controls.Add(this.ht);
            this.groupBox3.Controls.Add(this.wt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(407, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Health Data";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Low physical Activity",
            "High physical Activity",
            "Moderate physical Activiy"});
            this.category.Location = new System.Drawing.Point(149, 125);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 28);
            this.category.TabIndex = 15;
            // 
            // ht
            // 
            this.ht.Location = new System.Drawing.Point(149, 42);
            this.ht.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(63, 26);
            this.ht.TabIndex = 14;
            this.toolTip1.SetToolTip(this.ht, "in cm");
            this.ht.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // wt
            // 
            this.wt.Location = new System.Drawing.Point(149, 80);
            this.wt.Name = "wt";
            this.wt.Size = new System.Drawing.Size(63, 26);
            this.wt.TabIndex = 13;
            this.toolTip1.SetToolTip(this.wt, "in kilograms");
            this.wt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lifestyle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(407, 267);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(140, 38);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.toolTip1.SetToolTip(this.Save, "For new entries SAVE");
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Updatenew
            // 
            this.Updatenew.Location = new System.Drawing.Point(574, 267);
            this.Updatenew.Name = "Updatenew";
            this.Updatenew.Size = new System.Drawing.Size(150, 38);
            this.Updatenew.TabIndex = 3;
            this.Updatenew.Text = "Update";
            this.toolTip1.SetToolTip(this.Updatenew, "For exisiting entries , Change the data");
            this.Updatenew.UseVisualStyleBackColor = true;
            this.Updatenew.Click += new System.EventHandler(this.Updatenew_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Save for a new user";
            // 
            // UserPage
            // 
            this.ClientSize = new System.Drawing.Size(771, 377);
            this.Controls.Add(this.Updatenew);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wt)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Updatenew;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.NumericUpDown ht;
        private System.Windows.Forms.NumericUpDown wt;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.DateTimePicker agebox;
    }
}