namespace WindowsFormsApplication1
{
    partial class Beginer
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
            this.lbl_beginerr = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.submit_btnn = new System.Windows.Forms.Button();
            this.o1 = new System.Windows.Forms.RadioButton();
            this.o2 = new System.Windows.Forms.RadioButton();
            this.o3 = new System.Windows.Forms.RadioButton();
            this.o4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_beginerr
            // 
            this.lbl_beginerr.AutoSize = true;
            this.lbl_beginerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_beginerr.Location = new System.Drawing.Point(69, 27);
            this.lbl_beginerr.Name = "lbl_beginerr";
            this.lbl_beginerr.Size = new System.Drawing.Size(139, 20);
            this.lbl_beginerr.TabIndex = 0;
            this.lbl_beginerr.Text = "Beginer Contest";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(23, 83);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(49, 13);
            this.lbl_question.TabIndex = 1;
            this.lbl_question.Text = "Question";
            this.lbl_question.Click += new System.EventHandler(this.lbl_question_Click);
            // 
            // submit_btnn
            // 
            this.submit_btnn.Location = new System.Drawing.Point(108, 208);
            this.submit_btnn.Name = "submit_btnn";
            this.submit_btnn.Size = new System.Drawing.Size(75, 23);
            this.submit_btnn.TabIndex = 2;
            this.submit_btnn.Text = "Submit";
            this.submit_btnn.UseVisualStyleBackColor = true;
            this.submit_btnn.Click += new System.EventHandler(this.submit_btnn_Click);
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Location = new System.Drawing.Point(44, 118);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(85, 17);
            this.o1.TabIndex = 3;
            this.o1.TabStop = true;
            this.o1.Text = "radioButton1";
            this.o1.UseVisualStyleBackColor = true;
            // 
            // o2
            // 
            this.o2.AutoSize = true;
            this.o2.Location = new System.Drawing.Point(163, 118);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(85, 17);
            this.o2.TabIndex = 4;
            this.o2.TabStop = true;
            this.o2.Text = "radioButton2";
            this.o2.UseVisualStyleBackColor = true;
            // 
            // o3
            // 
            this.o3.AutoSize = true;
            this.o3.Location = new System.Drawing.Point(44, 164);
            this.o3.Name = "o3";
            this.o3.Size = new System.Drawing.Size(85, 17);
            this.o3.TabIndex = 5;
            this.o3.TabStop = true;
            this.o3.Text = "radioButton3";
            this.o3.UseVisualStyleBackColor = true;
            // 
            // o4
            // 
            this.o4.AutoSize = true;
            this.o4.Location = new System.Drawing.Point(163, 164);
            this.o4.Name = "o4";
            this.o4.Size = new System.Drawing.Size(85, 17);
            this.o4.TabIndex = 6;
            this.o4.TabStop = true;
            this.o4.Text = "radioButton4";
            this.o4.UseVisualStyleBackColor = true;
            // 
            // Beginer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.o4);
            this.Controls.Add(this.o3);
            this.Controls.Add(this.o2);
            this.Controls.Add(this.o1);
            this.Controls.Add(this.submit_btnn);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.lbl_beginerr);
            this.Name = "Beginer";
            this.Text = "Beginer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_beginerr;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Button submit_btnn;
        private System.Windows.Forms.RadioButton o1;
        private System.Windows.Forms.RadioButton o2;
        private System.Windows.Forms.RadioButton o3;
        private System.Windows.Forms.RadioButton o4;
    }
}