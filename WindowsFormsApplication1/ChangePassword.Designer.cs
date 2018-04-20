namespace WindowsFormsApplication1
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_oldpassword = new System.Windows.Forms.TextBox();
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.txt_cnewpassword = new System.Windows.Forms.TextBox();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // txt_oldpassword
            // 
            this.txt_oldpassword.Location = new System.Drawing.Point(213, 41);
            this.txt_oldpassword.Name = "txt_oldpassword";
            this.txt_oldpassword.PasswordChar = '*';
            this.txt_oldpassword.Size = new System.Drawing.Size(100, 20);
            this.txt_oldpassword.TabIndex = 3;
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Location = new System.Drawing.Point(213, 77);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '*';
            this.txt_newpassword.Size = new System.Drawing.Size(100, 20);
            this.txt_newpassword.TabIndex = 4;
            // 
            // txt_cnewpassword
            // 
            this.txt_cnewpassword.Location = new System.Drawing.Point(213, 115);
            this.txt_cnewpassword.Name = "txt_cnewpassword";
            this.txt_cnewpassword.PasswordChar = '*';
            this.txt_cnewpassword.Size = new System.Drawing.Size(100, 20);
            this.txt_cnewpassword.TabIndex = 5;
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(96, 168);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(154, 23);
            this.btn_changePassword.TabIndex = 6;
            this.btn_changePassword.Text = "Change Password";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            this.label5.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 269);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.txt_cnewpassword);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.txt_oldpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_oldpassword;
        private System.Windows.Forms.TextBox txt_newpassword;
        private System.Windows.Forms.TextBox txt_cnewpassword;
        private System.Windows.Forms.Button btn_changePassword;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
    }
}