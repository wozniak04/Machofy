
namespace Aplikacja
{
    partial class Rejestracja
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
            this.btnRejestruj = new System.Windows.Forms.Button();
            this.tHaslo1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tHaslo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRejestruj
            // 
            this.btnRejestruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRejestruj.Font = new System.Drawing.Font("Impact", 11.25F);
            this.btnRejestruj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRejestruj.Location = new System.Drawing.Point(129, 290);
            this.btnRejestruj.Name = "btnRejestruj";
            this.btnRejestruj.Size = new System.Drawing.Size(100, 30);
            this.btnRejestruj.TabIndex = 11;
            this.btnRejestruj.Text = "Zarejestruj";
            this.btnRejestruj.UseVisualStyleBackColor = false;
            this.btnRejestruj.Click += new System.EventHandler(this.button1_Click);
            // 
            // tHaslo1
            // 
            this.tHaslo1.Location = new System.Drawing.Point(129, 187);
            this.tHaslo1.Name = "tHaslo1";
            this.tHaslo1.Size = new System.Drawing.Size(195, 20);
            this.tHaslo1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(76, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(77, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(129, 145);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(195, 20);
            this.tEmail.TabIndex = 7;
            // 
            // tHaslo2
            // 
            this.tHaslo2.Location = new System.Drawing.Point(129, 228);
            this.tHaslo2.Name = "tHaslo2";
            this.tHaslo2.Size = new System.Drawing.Size(195, 20);
            this.tHaslo2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(23, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Powtórz Hasło:";
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.tHaslo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRejestruj);
            this.Controls.Add(this.tHaslo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tEmail);
            this.Name = "Rejestracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRejestruj;
        private System.Windows.Forms.TextBox tHaslo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tHaslo2;
        private System.Windows.Forms.Label label3;
    }
}