namespace DBMS_FitnessTracker
{
    partial class ActLog
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
            this.history = new System.Windows.Forms.Label();
            this.actname = new System.Windows.Forms.Label();
            this.actdur = new System.Windows.Forms.Label();
            this.actwork = new System.Windows.Forms.Label();
            this.workhigh = new System.Windows.Forms.RadioButton();
            this.worklow = new System.Windows.Forms.RadioButton();
            this.actrem = new System.Windows.Forms.Label();
            this.actsub = new System.Windows.Forms.Button();
            this.actiname = new System.Windows.Forms.ComboBox();
            this.actrem1 = new System.Windows.Forms.TextBox();
            this.mustdo = new System.Windows.Forms.Label();
            this.addnew = new System.Windows.Forms.GroupBox();
            this.acthis = new System.Windows.Forms.CheckedListBox();
            this.actdur1 = new System.Windows.Forms.TextBox();
            this.addnew.SuspendLayout();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Location = new System.Drawing.Point(9, 163);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(68, 13);
            this.history.TabIndex = 0;
            this.history.Text = "About Today";
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // actname
            // 
            this.actname.AutoSize = true;
            this.actname.Location = new System.Drawing.Point(249, 57);
            this.actname.Name = "actname";
            this.actname.Size = new System.Drawing.Size(72, 13);
            this.actname.TabIndex = 3;
            this.actname.Text = "Activity Name";
            // 
            // actdur
            // 
            this.actdur.AutoSize = true;
            this.actdur.Location = new System.Drawing.Point(249, 91);
            this.actdur.Name = "actdur";
            this.actdur.Size = new System.Drawing.Size(88, 13);
            this.actdur.TabIndex = 5;
            this.actdur.Text = "Duration (in mins)";
            // 
            // actwork
            // 
            this.actwork.AutoSize = true;
            this.actwork.Location = new System.Drawing.Point(249, 122);
            this.actwork.Name = "actwork";
            this.actwork.Size = new System.Drawing.Size(93, 13);
            this.actwork.TabIndex = 7;
            this.actwork.Text = "Workout  Intensity";
            // 
            // workhigh
            // 
            this.workhigh.AutoSize = true;
            this.workhigh.Location = new System.Drawing.Point(373, 121);
            this.workhigh.Name = "workhigh";
            this.workhigh.Size = new System.Drawing.Size(47, 17);
            this.workhigh.TabIndex = 8;
            this.workhigh.TabStop = true;
            this.workhigh.Text = "High";
            this.workhigh.UseVisualStyleBackColor = true;
            // 
            // worklow
            // 
            this.worklow.AutoSize = true;
            this.worklow.Location = new System.Drawing.Point(373, 145);
            this.worklow.Name = "worklow";
            this.worklow.Size = new System.Drawing.Size(45, 17);
            this.worklow.TabIndex = 9;
            this.worklow.TabStop = true;
            this.worklow.Text = "Low";
            this.worklow.UseVisualStyleBackColor = true;
            // 
            // actrem
            // 
            this.actrem.AutoSize = true;
            this.actrem.Location = new System.Drawing.Point(249, 182);
            this.actrem.Name = "actrem";
            this.actrem.Size = new System.Drawing.Size(44, 13);
            this.actrem.TabIndex = 10;
            this.actrem.Text = "Remark";
            // 
            // actsub
            // 
            this.actsub.Location = new System.Drawing.Point(334, 221);
            this.actsub.Name = "actsub";
            this.actsub.Size = new System.Drawing.Size(75, 23);
            this.actsub.TabIndex = 12;
            this.actsub.Text = "Submit";
            this.actsub.UseVisualStyleBackColor = true;
            this.actsub.Click += new System.EventHandler(this.actsub_Click);
            // 
            // actiname
            // 
            this.actiname.FormattingEnabled = true;
            this.actiname.Location = new System.Drawing.Point(355, 54);
            this.actiname.Name = "actiname";
            this.actiname.Size = new System.Drawing.Size(121, 21);
            this.actiname.TabIndex = 13;
            this.actiname.SelectedIndexChanged += new System.EventHandler(this.FillCombo_SelectedIndexChanged);
            // 
            // actrem1
            // 
            this.actrem1.Location = new System.Drawing.Point(355, 179);
            this.actrem1.Name = "actrem1";
            this.actrem1.Size = new System.Drawing.Size(120, 20);
            this.actrem1.TabIndex = 14;
            this.actrem1.Text = "Say normal or unusual";
            // 
            // mustdo
            // 
            this.mustdo.AutoSize = true;
            this.mustdo.Location = new System.Drawing.Point(9, 9);
            this.mustdo.Name = "mustdo";
            this.mustdo.Size = new System.Drawing.Size(47, 13);
            this.mustdo.TabIndex = 15;
            this.mustdo.Text = "Must Do";
            this.mustdo.Click += new System.EventHandler(this.mustdo_Click);
            // 
            // addnew
            // 
            this.addnew.Controls.Add(this.actdur1);
            this.addnew.Location = new System.Drawing.Point(209, 19);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(300, 261);
            this.addnew.TabIndex = 16;
            this.addnew.TabStop = false;
            this.addnew.Text = "Add New";
            // 
            // acthis
            // 
            this.acthis.FormattingEnabled = true;
            this.acthis.Location = new System.Drawing.Point(12, 182);
            this.acthis.Name = "acthis";
            this.acthis.Size = new System.Drawing.Size(120, 94);
            this.acthis.TabIndex = 17;
            // 
            // actdur1
            // 
            this.actdur1.Location = new System.Drawing.Point(146, 72);
            this.actdur1.Name = "actdur1";
            this.actdur1.Size = new System.Drawing.Size(100, 20);
            this.actdur1.TabIndex = 0;
            // 
            // ActLog
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.acthis);
            this.Controls.Add(this.mustdo);
            this.Controls.Add(this.actrem1);
            this.Controls.Add(this.actiname);
            this.Controls.Add(this.actsub);
            this.Controls.Add(this.actrem);
            this.Controls.Add(this.worklow);
            this.Controls.Add(this.workhigh);
            this.Controls.Add(this.actwork);
            this.Controls.Add(this.actdur);
            this.Controls.Add(this.actname);
            this.Controls.Add(this.history);
            this.Controls.Add(this.addnew);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActLog";
            this.Text = "ActLog";
            this.Load += new System.EventHandler(this.ActLog_Load);
            this.addnew.ResumeLayout(false);
            this.addnew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Label actname;
        private System.Windows.Forms.Label actdur;
        private System.Windows.Forms.Label actwork;
        private System.Windows.Forms.RadioButton workhigh;
        private System.Windows.Forms.RadioButton worklow;
        private System.Windows.Forms.Label actrem;
        private System.Windows.Forms.Button actsub;
        private System.Windows.Forms.ComboBox actiname;
        private System.Windows.Forms.TextBox actrem1;
        private System.Windows.Forms.Label mustdo;
        private System.Windows.Forms.GroupBox addnew;
        private System.Windows.Forms.CheckedListBox acthis;
        private System.Windows.Forms.TextBox actdur1;
    }
}