namespace ProblemOne
{
    partial class Form1
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
            this.lblWord = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtText1 = new System.Windows.Forms.TextBox();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(12, 29);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(47, 13);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Kelime 1";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 67);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(47, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Kelime 2";
            // 
            // txtText1
            // 
            this.txtText1.Location = new System.Drawing.Point(80, 26);
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(405, 20);
            this.txtText1.TabIndex = 2;
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(80, 64);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(405, 20);
            this.txtText2.TabIndex = 3;
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(410, 100);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(75, 23);
            this.btnContains.TabIndex = 4;
            this.btnContains.Text = "Kelime Ara";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 141);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.txtText2);
            this.Controls.Add(this.txtText1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtText1;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.Button btnContains;
    }
}

