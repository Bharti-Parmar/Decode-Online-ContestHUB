namespace WindowsFormsApplication1
{
    partial class Codechef
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
            this.Submit_btnn = new System.Windows.Forms.Button();
            this.lbl_codechef = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.O1 = new System.Windows.Forms.RadioButton();
            this.O2 = new System.Windows.Forms.RadioButton();
            this.O3 = new System.Windows.Forms.RadioButton();
            this.O4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Submit_btnn
            // 
            this.Submit_btnn.Location = new System.Drawing.Point(104, 202);
            this.Submit_btnn.Name = "Submit_btnn";
            this.Submit_btnn.Size = new System.Drawing.Size(75, 23);
            this.Submit_btnn.TabIndex = 0;
            this.Submit_btnn.Text = "Submit";
            this.Submit_btnn.UseVisualStyleBackColor = false;
            this.Submit_btnn.Click += new System.EventHandler(this.Submit_btnn_Click);
            // 
            // lbl_codechef
            // 
            this.lbl_codechef.AutoSize = true;
            this.lbl_codechef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codechef.Location = new System.Drawing.Point(100, 25);
            this.lbl_codechef.Name = "lbl_codechef";
            this.lbl_codechef.Size = new System.Drawing.Size(94, 20);
            this.lbl_codechef.TabIndex = 1;
            this.lbl_codechef.Text = "Code Chef";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(25, 76);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(49, 13);
            this.lbl_question.TabIndex = 2;
            this.lbl_question.Text = "Question";
            // 
            // O1
            // 
            this.O1.AutoSize = true;
            this.O1.Location = new System.Drawing.Point(43, 115);
            this.O1.Name = "O1";
            this.O1.Size = new System.Drawing.Size(85, 17);
            this.O1.TabIndex = 3;
            this.O1.TabStop = true;
            this.O1.Text = "radioButton1";
            this.O1.UseVisualStyleBackColor = true;
            // 
            // O2
            // 
            this.O2.AutoSize = true;
            this.O2.Location = new System.Drawing.Point(169, 115);
            this.O2.Name = "O2";
            this.O2.Size = new System.Drawing.Size(85, 17);
            this.O2.TabIndex = 4;
            this.O2.TabStop = true;
            this.O2.Text = "radioButton2";
            this.O2.UseVisualStyleBackColor = true;
            // 
            // O3
            // 
            this.O3.AutoSize = true;
            this.O3.Location = new System.Drawing.Point(43, 161);
            this.O3.Name = "O3";
            this.O3.Size = new System.Drawing.Size(85, 17);
            this.O3.TabIndex = 5;
            this.O3.TabStop = true;
            this.O3.Text = "radioButton3";
            this.O3.UseVisualStyleBackColor = true;
            // 
            // O4
            // 
            this.O4.AutoSize = true;
            this.O4.Location = new System.Drawing.Point(169, 161);
            this.O4.Name = "O4";
            this.O4.Size = new System.Drawing.Size(85, 17);
            this.O4.TabIndex = 6;
            this.O4.TabStop = true;
            this.O4.Text = "radioButton4";
            this.O4.UseVisualStyleBackColor = true;
            // 
            // Codechef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.O4);
            this.Controls.Add(this.O3);
            this.Controls.Add(this.O2);
            this.Controls.Add(this.O1);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.lbl_codechef);
            this.Controls.Add(this.Submit_btnn);
            this.Name = "Codechef";
            this.Text = "Codechef";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_btnn;
        private System.Windows.Forms.Label lbl_codechef;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.RadioButton O1;
        private System.Windows.Forms.RadioButton O2;
        private System.Windows.Forms.RadioButton O3;
        private System.Windows.Forms.RadioButton O4;
    }
}