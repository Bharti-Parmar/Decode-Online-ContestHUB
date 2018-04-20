namespace WindowsFormsApplication1
{
    partial class DeleteUser
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
            this.lbl_selectUser = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.cBox_selectuser = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_selectUser
            // 
            this.lbl_selectUser.AutoSize = true;
            this.lbl_selectUser.Location = new System.Drawing.Point(41, 42);
            this.lbl_selectUser.Name = "lbl_selectUser";
            this.lbl_selectUser.Size = new System.Drawing.Size(62, 13);
            this.lbl_selectUser.TabIndex = 0;
            this.lbl_selectUser.Text = "Select User";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(146, 76);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 1;
            this.lbl_message.Click += new System.EventHandler(this.lbl_message_Click);
            // 
            // cBox_selectuser
            // 
            this.cBox_selectuser.FormattingEnabled = true;
            this.cBox_selectuser.Location = new System.Drawing.Point(135, 39);
            this.cBox_selectuser.Name = "cBox_selectuser";
            this.cBox_selectuser.Size = new System.Drawing.Size(121, 21);
            this.cBox_selectuser.TabIndex = 2;
            this.cBox_selectuser.SelectedIndexChanged += new System.EventHandler(this.cBox_selectuser_SelectedIndexChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(102, 122);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 191);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cBox_selectuser);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_selectUser);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectUser;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.ComboBox cBox_selectuser;
        private System.Windows.Forms.Button btn_delete;
    }
}