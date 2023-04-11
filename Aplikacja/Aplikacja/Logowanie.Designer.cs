
namespace Aplikacja
{
    partial class Logowanie
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
            this.tEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tHaslo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRejestruj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(128, 159);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(174, 20);
            this.tEmail.TabIndex = 1;
            this.tEmail.TextChanged += new System.EventHandler(this.tEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(76, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(75, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło:";
            // 
            // tHaslo
            // 
            this.tHaslo.Location = new System.Drawing.Point(128, 229);
            this.tHaslo.Name = "tHaslo";
            this.tHaslo.Size = new System.Drawing.Size(174, 20);
            this.tHaslo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button1.Font = new System.Drawing.Font("Impact", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.Location = new System.Drawing.Point(128, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRejestruj
            // 
            this.btnRejestruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRejestruj.Font = new System.Drawing.Font("Impact", 11.25F);
            this.btnRejestruj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRejestruj.Location = new System.Drawing.Point(128, 352);
            this.btnRejestruj.Name = "btnRejestruj";
            this.btnRejestruj.Size = new System.Drawing.Size(100, 30);
            this.btnRejestruj.TabIndex = 6;
            this.btnRejestruj.Text = "Rejestracja";
            this.btnRejestruj.UseVisualStyleBackColor = false;
            this.btnRejestruj.Click += new System.EventHandler(this.btnRejestruj_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.btnRejestruj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tHaslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tEmail);
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tHaslo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRejestruj;
    }
}