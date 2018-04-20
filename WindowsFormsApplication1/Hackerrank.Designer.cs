namespace WindowsFormsApplication1
{
    partial class Hackerrank
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
            this.lbl_hackerRank = new System.Windows.Forms.Label();
            this.lbl_questions = new System.Windows.Forms.Label();
            this.btn_submitt = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_hackerRank
            // 
            this.lbl_hackerRank.AutoSize = true;
            this.lbl_hackerRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hackerRank.Location = new System.Drawing.Point(101, 27);
            this.lbl_hackerRank.Name = "lbl_hackerRank";
            this.lbl_hackerRank.Size = new System.Drawing.Size(113, 20);
            this.lbl_hackerRank.TabIndex = 0;
            this.lbl_hackerRank.Text = "Hacker Rank";
            // 
            // lbl_questions
            // 
            this.lbl_questions.AutoSize = true;
            this.lbl_questions.Location = new System.Drawing.Point(42, 77);
            this.lbl_questions.Name = "lbl_questions";
            this.lbl_questions.Size = new System.Drawing.Size(49, 13);
            this.lbl_questions.TabIndex = 1;
            this.lbl_questions.Text = "Question";
            // 
            // btn_submitt
            // 
            this.btn_submitt.Location = new System.Drawing.Point(105, 209);
            this.btn_submitt.Name = "btn_submitt";
            this.btn_submitt.Size = new System.Drawing.Size(75, 23);
            this.btn_submitt.TabIndex = 2;
            this.btn_submitt.Text = "Submit";
            this.btn_submitt.UseVisualStyleBackColor = true;
            this.btn_submitt.Click += new System.EventHandler(this.btn_submitt_Click);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Location = new System.Drawing.Point(50, 120);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(85, 17);
            this.option1.TabIndex = 3;
            this.option1.TabStop = true;
            this.option1.Text = "radioButton1";
            this.option1.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(176, 120);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(85, 17);
            this.option2.TabIndex = 4;
            this.option2.TabStop = true;
            this.option2.Text = "radioButton2";
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Location = new System.Drawing.Point(50, 162);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(85, 17);
            this.option3.TabIndex = 5;
            this.option3.TabStop = true;
            this.option3.Text = "radioButton3";
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Location = new System.Drawing.Point(176, 162);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(85, 17);
            this.option4.TabIndex = 6;
            this.option4.TabStop = true;
            this.option4.Text = "radioButton4";
            this.option4.UseVisualStyleBackColor = true;
            // 
            // Hackerrank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.btn_submitt);
            this.Controls.Add(this.lbl_questions);
            this.Controls.Add(this.lbl_hackerRank);
            this.Name = "Hackerrank";
            this.Text = "Hackerrank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hackerRank;
        private System.Windows.Forms.Label lbl_questions;
        private System.Windows.Forms.Button btn_submitt;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option4;
    }
}