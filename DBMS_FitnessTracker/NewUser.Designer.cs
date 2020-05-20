namespace DBMS_FitnessTracker
{
    partial class NewUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.createAccnt = new System.Windows.Forms.Button();
            this.newPwd = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.createAccnt);
            this.groupBox1.Controls.Add(this.newPwd);
            this.groupBox1.Controls.Add(this.pwd);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Go back to login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createAccnt
            // 
            this.createAccnt.Location = new System.Drawing.Point(118, 225);
            this.createAccnt.Name = "createAccnt";
            this.createAccnt.Size = new System.Drawing.Size(198, 35);
            this.createAccnt.TabIndex = 6;
            this.createAccnt.Text = "Create Account";
            this.createAccnt.UseVisualStyleBackColor = true;
            this.createAccnt.Click += new System.EventHandler(this.CreateAccnt_Click1);
            // 
            // newPwd
            // 
            this.newPwd.Location = new System.Drawing.Point(216, 158);
            this.newPwd.Name = "newPwd";
            this.newPwd.Size = new System.Drawing.Size(154, 26);
            this.newPwd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.newPwd, "Reenter password");
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(216, 106);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(154, 26);
            this.pwd.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pwd, "New password");
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(216, 51);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(202, 26);
            this.userName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.userName, "This is your new username");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password***";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter user name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 57);
            this.label4.TabIndex = 8;
            this.label4.Text = "***Password must contain minimum of one number, special character and uppercase l" +
    "etter";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 522);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createAccnt;
        private System.Windows.Forms.TextBox newPwd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}