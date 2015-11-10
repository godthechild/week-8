namespace twozerofoureight
{
    partial class TwoZeroFourEightScoreView
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
            this.SC = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SC
            // 
            this.SC.AutoSize = true;
            this.SC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.SC.Location = new System.Drawing.Point(74, 28);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(139, 39);
            this.SC.TabIndex = 0;
            this.SC.Text = "SCORE";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblScore.Location = new System.Drawing.Point(118, 140);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(36, 39);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "4";
            this.lblScore.Click += new System.EventHandler(this.num_Click);
            // 
            // TwoZeroFourEightScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.SC);
            this.Name = "TwoZeroFourEightScoreView";
            this.Text = "TwoZeroFourEightScoreView";
            this.Load += new System.EventHandler(this.TwoZeroFourEightScoreView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SC;
        private System.Windows.Forms.Label lblScore;
    }
}