namespace DBMS_FitnessTracker
{
    partial class login
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
            this.logout = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.login1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(373, 290);
            this.logout.Margin = new System.Windows.Forms.Padding(2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(97, 27);
            this.logout.TabIndex = 10;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(431, 184);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(68, 20);
            this.user.TabIndex = 9;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(373, 236);
            this.login1.Margin = new System.Windows.Forms.Padding(2);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(91, 31);
            this.login1.TabIndex = 8;
            this.login1.Text = "Log IN";
            this.login1.UseVisualStyleBackColor = true;
            this.login1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter User name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to FT";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.user);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button login1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}