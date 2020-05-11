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
            this.finishbut = new System.Windows.Forms.Button();
            this.actdur1 = new System.Windows.Forms.TextBox();
            this.acthis = new System.Windows.Forms.CheckedListBox();
            this.goalsdo = new System.Windows.Forms.ListBox();
            this.addnew.SuspendLayout();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(14, 251);
            this.history.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(143, 26);
            this.history.TabIndex = 0;
            this.history.Text = "About Today";
            
            // 
            // actname
            // 
            this.actname.AutoSize = true;
            this.actname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actname.Location = new System.Drawing.Point(76, 51);
            this.actname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actname.Name = "actname";
            this.actname.Size = new System.Drawing.Size(131, 25);
            this.actname.TabIndex = 3;
            this.actname.Text = "Activity Name";
            // 
            // actdur
            // 
            this.actdur.AutoSize = true;
            this.actdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actdur.Location = new System.Drawing.Point(76, 122);
            this.actdur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actdur.Name = "actdur";
            this.actdur.Size = new System.Drawing.Size(165, 25);
            this.actdur.TabIndex = 5;
            this.actdur.Text = "Duration (in mins)";
            // 
            // actwork
            // 
            this.actwork.AutoSize = true;
            this.actwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actwork.Location = new System.Drawing.Point(76, 194);
            this.actwork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actwork.Name = "actwork";
            this.actwork.Size = new System.Drawing.Size(168, 25);
            this.actwork.TabIndex = 7;
            this.actwork.Text = "Workout  Intensity";
            // 
            // workhigh
            // 
            this.workhigh.AutoSize = true;
            this.workhigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workhigh.Location = new System.Drawing.Point(309, 191);
            this.workhigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workhigh.Name = "workhigh";
            this.workhigh.Size = new System.Drawing.Size(72, 26);
            this.workhigh.TabIndex = 8;
            this.workhigh.TabStop = true;
            this.workhigh.Text = "High";
            this.workhigh.UseVisualStyleBackColor = true;
            // 
            // worklow
            // 
            this.worklow.AutoSize = true;
            this.worklow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worklow.Location = new System.Drawing.Point(309, 249);
            this.worklow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.worklow.Name = "worklow";
            this.worklow.Size = new System.Drawing.Size(68, 26);
            this.worklow.TabIndex = 9;
            this.worklow.TabStop = true;
            this.worklow.Text = "Low";
            this.worklow.UseVisualStyleBackColor = true;
            // 
            // actrem
            // 
            this.actrem.AutoSize = true;
            this.actrem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actrem.Location = new System.Drawing.Point(76, 302);
            this.actrem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actrem.Name = "actrem";
            this.actrem.Size = new System.Drawing.Size(79, 25);
            this.actrem.TabIndex = 10;
            this.actrem.Text = "Remark";
            // 
            // actsub
            // 
            this.actsub.Location = new System.Drawing.Point(106, 392);
            this.actsub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actsub.Name = "actsub";
            this.actsub.Size = new System.Drawing.Size(123, 55);
            this.actsub.TabIndex = 12;
            this.actsub.Text = "Submit";
            this.actsub.UseVisualStyleBackColor = true;
            this.actsub.Click += new System.EventHandler(this.actsub_Click);
            // 
            // actiname
            // 
            this.actiname.FormattingEnabled = true;
            this.actiname.Location = new System.Drawing.Point(309, 51);
            this.actiname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actiname.Name = "actiname";
            this.actiname.Size = new System.Drawing.Size(180, 34);
            this.actiname.TabIndex = 13;
            
            // 
            // actrem1
            // 
            this.actrem1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actrem1.Location = new System.Drawing.Point(309, 302);
            this.actrem1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actrem1.Name = "actrem1";
            this.actrem1.Size = new System.Drawing.Size(178, 28);
            this.actrem1.TabIndex = 14;
            this.actrem1.Text = "Usual";
            // 
            // mustdo
            // 
            this.mustdo.AutoSize = true;
            this.mustdo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mustdo.Location = new System.Drawing.Point(14, 14);
            this.mustdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mustdo.Name = "mustdo";
            this.mustdo.Size = new System.Drawing.Size(117, 26);
            this.mustdo.TabIndex = 15;
            this.mustdo.Text = "Your Goal";
          
            // 
            // addnew
            // 
            this.addnew.Controls.Add(this.finishbut);
            this.addnew.Controls.Add(this.actdur1);
            this.addnew.Controls.Add(this.actsub);
            this.addnew.Controls.Add(this.actiname);
            this.addnew.Controls.Add(this.actrem1);
            this.addnew.Controls.Add(this.actdur);
            this.addnew.Controls.Add(this.worklow);
            this.addnew.Controls.Add(this.actname);
            this.addnew.Controls.Add(this.workhigh);
            this.addnew.Controls.Add(this.actrem);
            this.addnew.Controls.Add(this.actwork);
            this.addnew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew.Location = new System.Drawing.Point(507, 32);
            this.addnew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addnew.Name = "addnew";
            this.addnew.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addnew.Size = new System.Drawing.Size(578, 497);
            this.addnew.TabIndex = 16;
            this.addnew.TabStop = false;
            this.addnew.Text = "Add New";
            // 
            // finishbut
            // 
            this.finishbut.Location = new System.Drawing.Point(338, 392);
            this.finishbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finishbut.Name = "finishbut";
            this.finishbut.Size = new System.Drawing.Size(140, 55);
            this.finishbut.TabIndex = 13;
            this.finishbut.Text = "Finish";
            this.finishbut.UseVisualStyleBackColor = true;
            this.finishbut.Click += new System.EventHandler(this.finishbut_Click);
            // 
            // actdur1
            // 
            this.actdur1.Location = new System.Drawing.Point(309, 117);
            this.actdur1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actdur1.Name = "actdur1";
            this.actdur1.Size = new System.Drawing.Size(148, 35);
            this.actdur1.TabIndex = 0;
            // 
            // acthis
            // 
            this.acthis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acthis.FormattingEnabled = true;
            this.acthis.Location = new System.Drawing.Point(58, 308);
            this.acthis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acthis.Name = "acthis";
            this.acthis.Size = new System.Drawing.Size(340, 229);
            this.acthis.TabIndex = 17;
            
            // 
            // goalsdo
            // 
            this.goalsdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalsdo.FormattingEnabled = true;
            this.goalsdo.ItemHeight = 22;
            this.goalsdo.Location = new System.Drawing.Point(58, 83);
            this.goalsdo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goalsdo.Name = "goalsdo";
            this.goalsdo.Size = new System.Drawing.Size(340, 136);
            this.goalsdo.TabIndex = 20;
            // 
            // ActLog
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 580);
            this.Controls.Add(this.goalsdo);
            this.Controls.Add(this.acthis);
            this.Controls.Add(this.mustdo);
            this.Controls.Add(this.history);
            this.Controls.Add(this.addnew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ListBox goalsdo;
        private System.Windows.Forms.Button finishbut;
    }
}