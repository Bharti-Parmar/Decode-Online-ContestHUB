namespace WindowsFormsApplication1
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Confirm_Password = new System.Windows.Forms.Label();
            this.usertype = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_Confirm_Password = new System.Windows.Forms.TextBox();
            this.btn_cnewuser = new System.Windows.Forms.Button();
            this.txt_usertype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(25, 116);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 13);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(25, 154);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 13);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            // 
            // Confirm_Password
            // 
            this.Confirm_Password.AutoSize = true;
            this.Confirm_Password.Location = new System.Drawing.Point(23, 194);
            this.Confirm_Password.Name = "Confirm_Password";
            this.Confirm_Password.Size = new System.Drawing.Size(91, 13);
            this.Confirm_Password.TabIndex = 2;
            this.Confirm_Password.Text = "Confirm Password";
            // 
            // usertype
            // 
            this.usertype.AutoSize = true;
            this.usertype.Location = new System.Drawing.Point(24, 230);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(47, 13);
            this.usertype.TabIndex = 3;
            this.usertype.Text = "usertype";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(155, 116);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(121, 20);
            this.txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(155, 154);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(121, 20);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_Confirm_Password
            // 
            this.txt_Confirm_Password.Location = new System.Drawing.Point(155, 194);
            this.txt_Confirm_Password.Name = "txt_Confirm_Password";
            this.txt_Confirm_Password.Size = new System.Drawing.Size(121, 20);
            this.txt_Confirm_Password.TabIndex = 6;
            this.txt_Confirm_Password.TextChanged += new System.EventHandler(this.txt_Confirm_Password_TextChanged);
            // 
            // btn_cnewuser
            // 
            this.btn_cnewuser.Location = new System.Drawing.Point(95, 277);
            this.btn_cnewuser.Name = "btn_cnewuser";
            this.btn_cnewuser.Size = new System.Drawing.Size(98, 23);
            this.btn_cnewuser.TabIndex = 7;
            this.btn_cnewuser.Text = "Create New User";
            this.btn_cnewuser.UseVisualStyleBackColor = true;
            this.btn_cnewuser.Click += new System.EventHandler(this.btn_cnewuser_Click);
            // 
            // txt_usertype
            // 
            this.txt_usertype.FormattingEnabled = true;
            this.txt_usertype.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.txt_usertype.Location = new System.Drawing.Point(155, 230);
            this.txt_usertype.Name = "txt_usertype";
            this.txt_usertype.Size = new System.Drawing.Size(121, 21);
            this.txt_usertype.TabIndex = 8;
            this.txt_usertype.SelectedIndexChanged += new System.EventHandler(this.txt_usertype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "city";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(157, 78);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(119, 20);
            this.txt_city.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(157, 40);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(119, 20);
            this.txt_name.TabIndex = 12;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 332);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usertype);
            this.Controls.Add(this.btn_cnewuser);
            this.Controls.Add(this.txt_Confirm_Password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.Confirm_Password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Confirm_Password;
        private System.Windows.Forms.Label usertype;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_Confirm_Password;
        private System.Windows.Forms.Button btn_cnewuser;
        private System.Windows.Forms.ComboBox txt_usertype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_name;
    }
}