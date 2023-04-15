
using System.Windows.Forms;

namespace Aplikacja
{
    partial class Ulubione
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Aplikacja = new System.Windows.Forms.Button();
            this.btn_zaloguj = new System.Windows.Forms.Button();
            this.odtwarzana_muzyka = new System.Windows.Forms.Label();
            this.tCzas = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_play = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lTytul = new System.Windows.Forms.Label();
            this.lCzas = new System.Windows.Forms.Label();
            this.ltotalczas = new System.Windows.Forms.Label();
            this.czasMuzyka = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tCzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Aplikacja
            // 
            this.btn_Aplikacja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Aplikacja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Aplikacja.FlatAppearance.BorderSize = 5;
            this.btn_Aplikacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aplikacja.Font = new System.Drawing.Font("Impact", 13F);
            this.btn_Aplikacja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Aplikacja.Location = new System.Drawing.Point(9, 9);
            this.btn_Aplikacja.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Aplikacja.Name = "btn_Aplikacja";
            this.btn_Aplikacja.Size = new System.Drawing.Size(97, 48);
            this.btn_Aplikacja.TabIndex = 2;
            this.btn_Aplikacja.Text = "Główna";
            this.btn_Aplikacja.UseVisualStyleBackColor = false;
            this.btn_Aplikacja.Click += new System.EventHandler(this.btn_Aplikacja_Click);
            // 
            // btn_zaloguj
            // 
            this.btn_zaloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_zaloguj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_zaloguj.FlatAppearance.BorderSize = 5;
            this.btn_zaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zaloguj.Font = new System.Drawing.Font("Impact", 13F);
            this.btn_zaloguj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_zaloguj.Location = new System.Drawing.Point(278, 9);
            this.btn_zaloguj.Margin = new System.Windows.Forms.Padding(0);
            this.btn_zaloguj.Name = "btn_zaloguj";
            this.btn_zaloguj.Size = new System.Drawing.Size(97, 48);
            this.btn_zaloguj.TabIndex = 4;
            this.btn_zaloguj.Text = "Wyloguj";
            this.btn_zaloguj.UseVisualStyleBackColor = false;
            this.btn_zaloguj.Click += new System.EventHandler(this.btn_zaloguj_Click);
            // 
            // odtwarzana_muzyka
            // 
            this.odtwarzana_muzyka.AutoSize = true;
            this.odtwarzana_muzyka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.odtwarzana_muzyka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odtwarzana_muzyka.Location = new System.Drawing.Point(166, 475);
            this.odtwarzana_muzyka.Name = "odtwarzana_muzyka";
            this.odtwarzana_muzyka.Size = new System.Drawing.Size(0, 13);
            this.odtwarzana_muzyka.TabIndex = 22;
            // 
            // tCzas
            // 
            this.tCzas.AutoSize = false;
            this.tCzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tCzas.LargeChange = 1;
            this.tCzas.Location = new System.Drawing.Point(-2, 443);
            this.tCzas.Margin = new System.Windows.Forms.Padding(0);
            this.tCzas.Maximum = 100;
            this.tCzas.Name = "tCzas";
            this.tCzas.Size = new System.Drawing.Size(391, 17);
            this.tCzas.TabIndex = 0;
            this.tCzas.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tCzas.Scroll += new System.EventHandler(this.tCzas_Scroll);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 109);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 331);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // btn_play
            // 
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(170)))), ((int)(((byte)(29)))));
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(170)))), ((int)(((byte)(29)))));
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(170)))), ((int)(((byte)(29)))));
            this.btn_play.Location = new System.Drawing.Point(169, 509);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(40, 40);
            this.btn_play.TabIndex = 8;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 463);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(391, 104);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lTytul
            // 
            this.lTytul.AutoSize = true;
            this.lTytul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lTytul.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTytul.Location = new System.Drawing.Point(12, 509);
            this.lTytul.Name = "lTytul";
            this.lTytul.Size = new System.Drawing.Size(32, 13);
            this.lTytul.TabIndex = 25;
            this.lTytul.Text = "Tytuł";
            // 
            // lCzas
            // 
            this.lCzas.AutoSize = true;
            this.lCzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lCzas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lCzas.Location = new System.Drawing.Point(172, 475);
            this.lCzas.Name = "lCzas";
            this.lCzas.Size = new System.Drawing.Size(30, 13);
            this.lCzas.TabIndex = 26;
            this.lCzas.Text = "Czas";
            // 
            // ltotalczas
            // 
            this.ltotalczas.AutoSize = true;
            this.ltotalczas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ltotalczas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ltotalczas.Location = new System.Drawing.Point(262, 509);
            this.ltotalczas.Name = "ltotalczas";
            this.ltotalczas.Size = new System.Drawing.Size(71, 13);
            this.ltotalczas.TabIndex = 27;
            this.ltotalczas.Text = "Czas Trwania";
            // 
            // czasMuzyka
            // 
            this.czasMuzyka.Tick += new System.EventHandler(this.czasMuzyka_Tick);
            // 
            // Ulubione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.ltotalczas);
            this.Controls.Add(this.lCzas);
            this.Controls.Add(this.lTytul);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tCzas);
            this.Controls.Add(this.odtwarzana_muzyka);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_zaloguj);
            this.Controls.Add(this.btn_Aplikacja);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ulubione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MachoFy";
            this.Load += new System.EventHandler(this.Aplikacja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tCzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Aplikacja;
        private System.Windows.Forms.Button btn_zaloguj;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label odtwarzana_muzyka;
        private System.Windows.Forms.TrackBar tCzas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lTytul;
        private Label lCzas;
        private Label ltotalczas;
        private Timer czasMuzyka;
    }
}