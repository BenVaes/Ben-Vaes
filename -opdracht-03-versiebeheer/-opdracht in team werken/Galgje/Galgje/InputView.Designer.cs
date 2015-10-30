namespace Galgje
{
    partial class InputView
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Woord = new System.Windows.Forms.Label();
            this.Levens = new System.Windows.Forms.Label();
            this.Infolabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.raadwoord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 277);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Raad letter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 251);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Woord
            // 
            this.Woord.AutoSize = true;
            this.Woord.Location = new System.Drawing.Point(190, 3);
            this.Woord.Name = "Woord";
            this.Woord.Size = new System.Drawing.Size(35, 13);
            this.Woord.TabIndex = 4;
            this.Woord.Text = "label2";
            // 
            // Levens
            // 
            this.Levens.AutoSize = true;
            this.Levens.Location = new System.Drawing.Point(190, 29);
            this.Levens.Name = "Levens";
            this.Levens.Size = new System.Drawing.Size(35, 13);
            this.Levens.TabIndex = 5;
            this.Levens.Text = "label2";
            // 
            // Infolabel
            // 
            this.Infolabel.AutoSize = true;
            this.Infolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Infolabel.Location = new System.Drawing.Point(42, 101);
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(0, 33);
            this.Infolabel.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2, 322);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weet u het woord? (fout -3 levens)";
            // 
            // raadwoord
            // 
            this.raadwoord.Location = new System.Drawing.Point(109, 318);
            this.raadwoord.Name = "raadwoord";
            this.raadwoord.Size = new System.Drawing.Size(75, 23);
            this.raadwoord.TabIndex = 9;
            this.raadwoord.Text = "Raad woord";
            this.raadwoord.UseVisualStyleBackColor = true;
            this.raadwoord.Click += new System.EventHandler(this.raadwoord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Raad een letter! (fout -1 leven)";
            // 
            // InputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.raadwoord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Infolabel);
            this.Controls.Add(this.Levens);
            this.Controls.Add(this.Woord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "InputView";
            this.Size = new System.Drawing.Size(317, 357);
            this.Load += new System.EventHandler(this.InputView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Woord;
        private System.Windows.Forms.Label Levens;
        private System.Windows.Forms.Label Infolabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button raadwoord;
        private System.Windows.Forms.Label label3;
    }
}
