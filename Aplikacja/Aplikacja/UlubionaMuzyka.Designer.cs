
namespace Aplikacja
{
    partial class UlubionaMuzyka
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImgWykonawca = new System.Windows.Forms.PictureBox();
            this.Wykonawca = new System.Windows.Forms.Label();
            this.Tytul = new System.Windows.Forms.Label();
            this.imgPlay = new System.Windows.Forms.PictureBox();
            this.pDisslike = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWykonawca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDisslike)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgWykonawca
            // 
            this.ImgWykonawca.Location = new System.Drawing.Point(3, 3);
            this.ImgWykonawca.Name = "ImgWykonawca";
            this.ImgWykonawca.Size = new System.Drawing.Size(52, 74);
            this.ImgWykonawca.TabIndex = 0;
            this.ImgWykonawca.TabStop = false;
            // 
            // Wykonawca
            // 
            this.Wykonawca.AutoSize = true;
            this.Wykonawca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Wykonawca.Location = new System.Drawing.Point(61, 13);
            this.Wykonawca.Name = "Wykonawca";
            this.Wykonawca.Size = new System.Drawing.Size(15, 13);
            this.Wykonawca.TabIndex = 1;
            this.Wykonawca.Text = "l1";
            // 
            // Tytul
            // 
            this.Tytul.AutoSize = true;
            this.Tytul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tytul.Location = new System.Drawing.Point(61, 54);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(15, 13);
            this.Tytul.TabIndex = 2;
            this.Tytul.Text = "l2";
            // 
            // imgPlay
            // 
            this.imgPlay.BackgroundImage = global::Aplikacja.Properties.Resources.button11;
            this.imgPlay.InitialImage = null;
            this.imgPlay.Location = new System.Drawing.Point(246, 13);
            this.imgPlay.Name = "imgPlay";
            this.imgPlay.Size = new System.Drawing.Size(40, 40);
            this.imgPlay.TabIndex = 3;
            this.imgPlay.TabStop = false;
            // 
            // pDisslike
            // 
            this.pDisslike.BackgroundImage = global::Aplikacja.Properties.Resources.dislike;
            this.pDisslike.InitialImage = null;
            this.pDisslike.Location = new System.Drawing.Point(207, 25);
            this.pDisslike.Name = "pDisslike";
            this.pDisslike.Size = new System.Drawing.Size(33, 28);
            this.pDisslike.TabIndex = 4;
            this.pDisslike.TabStop = false;
            this.pDisslike.Click += new System.EventHandler(this.pDisslike_Click);
            // 
            // UlubionaMuzyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pDisslike);
            this.Controls.Add(this.imgPlay);
            this.Controls.Add(this.Tytul);
            this.Controls.Add(this.Wykonawca);
            this.Controls.Add(this.ImgWykonawca);
            this.Name = "UlubionaMuzyka";
            this.Size = new System.Drawing.Size(300, 80);
            this.Load += new System.EventHandler(this.Muzyki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgWykonawca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDisslike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgWykonawca;
        private System.Windows.Forms.Label Wykonawca;
        private System.Windows.Forms.Label Tytul;
        private System.Windows.Forms.PictureBox imgPlay;
        private System.Windows.Forms.PictureBox pDisslike;
    }
}
