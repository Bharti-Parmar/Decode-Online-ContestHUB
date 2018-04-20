namespace WindowsFormsApplication1
{
    partial class Team
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_bharti = new System.Windows.Forms.Button();
            this.btn_atul = new System.Windows.Forms.Button();
            this.btn_partha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(63, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(153, 27);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Team Member";
            // 
            // btn_bharti
            // 
            this.btn_bharti.Location = new System.Drawing.Point(61, 82);
            this.btn_bharti.Name = "btn_bharti";
            this.btn_bharti.Size = new System.Drawing.Size(155, 23);
            this.btn_bharti.TabIndex = 1;
            this.btn_bharti.Text = "Bharti Parmar";
            this.btn_bharti.UseVisualStyleBackColor = true;
            this.btn_bharti.Click += new System.EventHandler(this.btn_bharti_Click);
            // 
            // btn_atul
            // 
            this.btn_atul.Location = new System.Drawing.Point(61, 127);
            this.btn_atul.Name = "btn_atul";
            this.btn_atul.Size = new System.Drawing.Size(155, 23);
            this.btn_atul.TabIndex = 2;
            this.btn_atul.Text = "Atul Anand";
            this.btn_atul.UseVisualStyleBackColor = true;
            this.btn_atul.Click += new System.EventHandler(this.btn_atul_Click);
            // 
            // btn_partha
            // 
            this.btn_partha.Location = new System.Drawing.Point(61, 169);
            this.btn_partha.Name = "btn_partha";
            this.btn_partha.Size = new System.Drawing.Size(155, 23);
            this.btn_partha.TabIndex = 3;
            this.btn_partha.Text = "Partha Biswas";
            this.btn_partha.UseVisualStyleBackColor = true;
            this.btn_partha.Click += new System.EventHandler(this.btn_partha_Click);
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_partha);
            this.Controls.Add(this.btn_atul);
            this.Controls.Add(this.btn_bharti);
            this.Controls.Add(this.lbl_name);
            this.Name = "Team";
            this.Text = "Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_bharti;
        private System.Windows.Forms.Button btn_atul;
        private System.Windows.Forms.Button btn_partha;
    }
}