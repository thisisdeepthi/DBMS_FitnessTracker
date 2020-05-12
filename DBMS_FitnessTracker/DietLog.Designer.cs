namespace DBMS_FitnessTracker
{
    partial class DietLog
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serving_no = new System.Windows.Forms.NumericUpDown();
            this.remarks = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.carbo_in = new System.Windows.Forms.RichTextBox();
            this.protein_in = new System.Windows.Forms.RichTextBox();
            this.vitamin_in = new System.Windows.Forms.RichTextBox();
            this.fat_in = new System.Windows.Forms.RichTextBox();
            this.cal_in = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.junks = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.diettoday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.serving_no)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diet Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No of serving";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remark";
            // 
            // serving_no
            // 
            this.serving_no.Location = new System.Drawing.Point(155, 73);
            this.serving_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serving_no.Name = "serving_no";
            this.serving_no.Size = new System.Drawing.Size(41, 22);
            this.serving_no.TabIndex = 5;
            // 
            // remarks
            // 
            this.remarks.Location = new System.Drawing.Point(155, 107);
            this.remarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(128, 22);
            this.remarks.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diet);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.remarks);
            this.groupBox1.Controls.Add(this.serving_no);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(293, 282);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // diet
            // 
            this.diet.FormattingEnabled = true;
            this.diet.Location = new System.Drawing.Point(155, 36);
            this.diet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diet.Name = "diet";
            this.diet.Size = new System.Drawing.Size(121, 24);
            this.diet.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(155, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add in my Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add new item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carbohydrates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Protein";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vitamins";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Junks till now";
            // 
            // carbo_in
            // 
            this.carbo_in.Location = new System.Drawing.Point(150, 32);
            this.carbo_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carbo_in.Name = "carbo_in";
            this.carbo_in.Size = new System.Drawing.Size(40, 26);
            this.carbo_in.TabIndex = 13;
            this.carbo_in.Text = "";
            // 
            // protein_in
            // 
            this.protein_in.Location = new System.Drawing.Point(150, 74);
            this.protein_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.protein_in.Name = "protein_in";
            this.protein_in.Size = new System.Drawing.Size(40, 26);
            this.protein_in.TabIndex = 15;
            this.protein_in.Text = "";
            // 
            // vitamin_in
            // 
            this.vitamin_in.Location = new System.Drawing.Point(150, 102);
            this.vitamin_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vitamin_in.Name = "vitamin_in";
            this.vitamin_in.Size = new System.Drawing.Size(40, 26);
            this.vitamin_in.TabIndex = 17;
            this.vitamin_in.Text = "";
            // 
            // fat_in
            // 
            this.fat_in.Location = new System.Drawing.Point(150, 139);
            this.fat_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fat_in.Name = "fat_in";
            this.fat_in.Size = new System.Drawing.Size(40, 26);
            this.fat_in.TabIndex = 19;
            this.fat_in.Text = "";
            // 
            // cal_in
            // 
            this.cal_in.Location = new System.Drawing.Point(150, 210);
            this.cal_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cal_in.Name = "cal_in";
            this.cal_in.Size = new System.Drawing.Size(81, 26);
            this.cal_in.TabIndex = 21;
            this.cal_in.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.junks);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cal_in);
            this.groupBox2.Controls.Add(this.fat_in);
            this.groupBox2.Controls.Add(this.vitamin_in);
            this.groupBox2.Controls.Add(this.protein_in);
            this.groupBox2.Controls.Add(this.carbo_in);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(402, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(252, 277);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // junks
            // 
            this.junks.Location = new System.Drawing.Point(150, 170);
            this.junks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.junks.Name = "junks";
            this.junks.Size = new System.Drawing.Size(40, 26);
            this.junks.TabIndex = 24;
            this.junks.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Calories";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(24, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nutrient Intake Today***";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.diettoday);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox3.Location = new System.Drawing.Point(698, 82);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(231, 277);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Already Taken Today";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(349, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "***All nutrients are in unit  per  and calories are in unit ";
            // 
            // diettoday
            // 
            this.diettoday.AutoSize = true;
            this.diettoday.Location = new System.Drawing.Point(7, 30);
            this.diettoday.Name = "diettoday";
            this.diettoday.Size = new System.Drawing.Size(97, 21);
            this.diettoday.TabIndex = 0;
            this.diettoday.Text = "diettoday";
            this.diettoday.UseVisualStyleBackColor = true;
            // 
            // DietLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 416);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DietLog";
            this.Text = "DietLog";
            ((System.ComponentModel.ISupportInitialize)(this.serving_no)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown serving_no;
        private System.Windows.Forms.TextBox remarks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox carbo_in;
        private System.Windows.Forms.RichTextBox protein_in;
        private System.Windows.Forms.RichTextBox vitamin_in;
        private System.Windows.Forms.RichTextBox fat_in;
        private System.Windows.Forms.RichTextBox cal_in;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox diet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox junks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox diettoday;
    }
}