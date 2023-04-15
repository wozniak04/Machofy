using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class Muzyki : UserControl
    {
        string Wykonawcas, Tytuls,Email;
        Image img;

        public event EventHandler<string> Clicked;

        public Muzyki(string wykonawca, string tytul, Image image,string user)
        {
            Wykonawcas = wykonawca;
            Tytuls = tytul;
            img = image;
            Email = user;
            InitializeComponent();

            this.imgPlay.Click += new EventHandler(Muzyki_Click);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var pol = new DataAcces();
            if(pol.dodajUlubienie(Email, Tytuls + "_" + Wykonawcas + ".wav"))
            {
                MessageBox.Show("dodano nową polubioną muzykę");
            }
        }

        private void Muzyki_Load(object sender, EventArgs e)
        {
            this.ImgWykonawca.Image = img;
            this.Wykonawca.Text = Wykonawcas;
            this.Tytul.Text = Tytuls;
        }

        private void Muzyki_Click(object sender, EventArgs e)
        {
            string tytul = Tytuls + "_" + Wykonawcas + ".wav";
            Clicked?.Invoke(this, tytul);
        }
    }
}
