namespace WindowsFormsApplication1
{
    partial class Contest
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
            System.Windows.Forms.Button btn_Codechef;
            this.lbl_contest = new System.Windows.Forms.Label();
            this.btn_beginer = new System.Windows.Forms.Button();
            this.btn_hackerrank = new System.Windows.Forms.Button();
            btn_Codechef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Codechef
            // 
            btn_Codechef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Codechef.Location = new System.Drawing.Point(64, 194);
            btn_Codechef.Name = "btn_Codechef";
            btn_Codechef.Size = new System.Drawing.Size(157, 29);
            btn_Codechef.TabIndex = 3;
            btn_Codechef.Text = "Code chef";
            btn_Codechef.UseVisualStyleBackColor = true;
            btn_Codechef.Click += new System.EventHandler(this.btn_Codechef_Click);
            // 
            // lbl_contest
            // 
            this.lbl_contest.AutoSize = true;
            this.lbl_contest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contest.Location = new System.Drawing.Point(87, 26);
            this.lbl_contest.Name = "lbl_contest";
            this.lbl_contest.Size = new System.Drawing.Size(87, 25);
            this.lbl_contest.TabIndex = 0;
            this.lbl_contest.Text = "Contest";
            // 
            // btn_beginer
            // 
            this.btn_beginer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beginer.Location = new System.Drawing.Point(64, 84);
            this.btn_beginer.Name = "btn_beginer";
            this.btn_beginer.Size = new System.Drawing.Size(157, 29);
            this.btn_beginer.TabIndex = 1;
            this.btn_beginer.Text = "Beginer";
            this.btn_beginer.UseVisualStyleBackColor = true;
            this.btn_beginer.Click += new System.EventHandler(this.btn_beginer_Click);
            // 
            // btn_hackerrank
            // 
            this.btn_hackerrank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hackerrank.Location = new System.Drawing.Point(64, 140);
            this.btn_hackerrank.Name = "btn_hackerrank";
            this.btn_hackerrank.Size = new System.Drawing.Size(157, 29);
            this.btn_hackerrank.TabIndex = 2;
            this.btn_hackerrank.Text = "Hacker Rank";
            this.btn_hackerrank.UseVisualStyleBackColor = true;
            this.btn_hackerrank.Click += new System.EventHandler(this.btn_hackerrank_Click);
            // 
            // Contest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(btn_Codechef);
            this.Controls.Add(this.btn_hackerrank);
            this.Controls.Add(this.btn_beginer);
            this.Controls.Add(this.lbl_contest);
            this.Name = "Contest";
            this.Text = "Contest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_contest;
        private System.Windows.Forms.Button btn_beginer;
        private System.Windows.Forms.Button btn_hackerrank;
    }
}