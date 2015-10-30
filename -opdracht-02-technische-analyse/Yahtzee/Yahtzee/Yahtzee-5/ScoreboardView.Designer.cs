namespace Yahtzee_5
{
    partial class ScoreboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.lblAantalWorpenLabel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAantalWorpen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaxAantalWorpen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.AutoSize = true;
            this.lblScoreLabel.Location = new System.Drawing.Point(49, 10);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(38, 13);
            this.lblScoreLabel.TabIndex = 0;
            this.lblScoreLabel.Text = "Score:";
            // 
            // lblAantalWorpenLabel
            // 
            this.lblAantalWorpenLabel.AutoSize = true;
            this.lblAantalWorpenLabel.Location = new System.Drawing.Point(9, 36);
            this.lblAantalWorpenLabel.Name = "lblAantalWorpenLabel";
            this.lblAantalWorpenLabel.Size = new System.Drawing.Size(78, 13);
            this.lblAantalWorpenLabel.TabIndex = 1;
            this.lblAantalWorpenLabel.Text = "Aantal worpen:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(94, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            this.lblScore.UseMnemonic = false;
            // 
            // lblAantalWorpen
            // 
            this.lblAantalWorpen.AutoSize = true;
            this.lblAantalWorpen.Location = new System.Drawing.Point(94, 36);
            this.lblAantalWorpen.Name = "lblAantalWorpen";
            this.lblAantalWorpen.Size = new System.Drawing.Size(13, 13);
            this.lblAantalWorpen.TabIndex = 3;
            this.lblAantalWorpen.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // lblMaxAantalWorpen
            // 
            this.lblMaxAantalWorpen.AutoSize = true;
            this.lblMaxAantalWorpen.Location = new System.Drawing.Point(115, 36);
            this.lblMaxAantalWorpen.Name = "lblMaxAantalWorpen";
            this.lblMaxAantalWorpen.Size = new System.Drawing.Size(13, 13);
            this.lblMaxAantalWorpen.TabIndex = 5;
            this.lblMaxAantalWorpen.Text = "0";
            // 
            // ScoreboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMaxAantalWorpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAantalWorpen);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblAantalWorpenLabel);
            this.Controls.Add(this.lblScoreLabel);
            this.Name = "ScoreboardView";
            this.Size = new System.Drawing.Size(150, 62);
            this.Load += new System.EventHandler(this.ScoreboardView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScoreLabel;
        private System.Windows.Forms.Label lblAantalWorpenLabel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAantalWorpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxAantalWorpen;
    }
}
