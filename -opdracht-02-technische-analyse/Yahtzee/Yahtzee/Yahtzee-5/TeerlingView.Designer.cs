namespace Yahtzee_5
{
    partial class TeerlingView
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
            this.lblTeerlingWaarde = new System.Windows.Forms.Label();
            this.btnWerp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeerlingWaarde
            // 
            this.lblTeerlingWaarde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTeerlingWaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTeerlingWaarde.Location = new System.Drawing.Point(10, 10);
            this.lblTeerlingWaarde.Margin = new System.Windows.Forms.Padding(0);
            this.lblTeerlingWaarde.Name = "lblTeerlingWaarde";
            this.lblTeerlingWaarde.Padding = new System.Windows.Forms.Padding(10);
            this.lblTeerlingWaarde.Size = new System.Drawing.Size(130, 130);
            this.lblTeerlingWaarde.TabIndex = 0;
            this.lblTeerlingWaarde.Text = "1";
            this.lblTeerlingWaarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTeerlingWaarde.Click += new System.EventHandler(this.teerling_Click);
            // 
            // btnWerp
            // 
            this.btnWerp.Location = new System.Drawing.Point(10, 144);
            this.btnWerp.Name = "btnWerp";
            this.btnWerp.Size = new System.Drawing.Size(130, 23);
            this.btnWerp.TabIndex = 1;
            this.btnWerp.Text = "Werp";
            this.btnWerp.UseVisualStyleBackColor = true;
            this.btnWerp.Click += new System.EventHandler(this.werpButton_Click);
            // 
            // TeerlingView
            // 
            this.Controls.Add(this.btnWerp);
            this.Controls.Add(this.lblTeerlingWaarde);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(150, 187);
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTeerlingWaarde;
        private System.Windows.Forms.Button btnWerp;
    }
}
