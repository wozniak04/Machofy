using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
namespace Aplikacja
{

    public partial class Aplikacja : Form
    {
        private WaveOutEvent waveOut = new WaveOutEvent();
        private long pozycja;
        private AudioFileReader audio;
        private string Tytul;
        private bool czygra = false;
       
        private string Email;
        public Aplikacja(string nazwa)
        {
            Email = nazwa;
            InitializeComponent();
           
        }

        


     

        private void button4_Click(object sender, EventArgs e)
        {
            if (czygra)
            {
                pozycja = audio.Position;
                waveOut.Stop();
                czygra = false;
                czasMuzyka.Enabled = false;
                btn_play.BackgroundImage = Properties.Resources.button11;
            }
            else
            {
                if (audio != null)
                {
                    audio.Position = pozycja;
                    waveOut.Play();
                    czygra = true;
                    czasMuzyka.Enabled = true;
                    btn_play.BackgroundImage = Properties.Resources.buttonpause;
                }
            }
            btn_play.FlatStyle = FlatStyle.Flat;
            btn_play.FlatAppearance.BorderSize = 0;
        }

        private void Aplikacja_Load(object sender, EventArgs e)
        {
            btn_play.BackgroundImage = Properties.Resources.buttonpause;
            foreach(string filepath in Directory.EnumerateFiles("../../Resources/Musics"))
            {
                string[] nazwamuzyki = Path.GetFileName(filepath).ToString().Split('_');
                var control = new Muzyki(nazwamuzyki[1].Split('.')[0],nazwamuzyki[0], (Image)Properties.Resources.ResourceManager.GetObject(Path.GetFileName(filepath).ToString().Split('.')[0]),Email);

                control.Clicked += new EventHandler<string>(Muzyki_Clicked);

                flowLayoutPanel1.Controls.Add(control);

            }


        }
        private void Muzyki_Clicked(object sender, string tytul)
        {
            if (czygra)
            {
                waveOut.Stop();
                czygra = !czygra;
            }
            btn_play.BackgroundImage = Properties.Resources.buttonpause;
            Tytul = tytul;
            audio = new AudioFileReader("../../Resources/Musics/" + Tytul);
            audio.Volume = 0.2f;
            waveOut.Init(audio);
            waveOut.Play();
            tCzas.Maximum = (int)audio.TotalTime.TotalSeconds;
            lTytul.Text = tytul.Split('.')[0];
            ltotalczas.Text ="Czas trwania : "+ audio.TotalTime.ToString(@"mm\:ss");
            czygra = !czygra;
            czasMuzyka.Enabled = true;
            
        }

        private void btn_zaloguj_Click(object sender, EventArgs e)
        {

        }

        private void czasMuzyka_Tick(object sender, EventArgs e)
        {
            if (audio != null)
            {
                lCzas.Text =audio.CurrentTime.ToString(@"mm\:ss");
                tCzas.Value = (int)audio.CurrentTime.TotalSeconds;
            }
        }

        private void tCzas_Scroll(object sender, EventArgs e)
        {
            if (audio != null)
            {
                audio.CurrentTime = TimeSpan.FromSeconds(tCzas.Value);
                pozycja = audio.Position;
            }
        }

        private void btn_ulubione_Click(object sender, EventArgs e)
        {
            var okno = new Ulubione(Email);
            this.Hide();
            okno.ShowDialog();
            this.Close();
        }
    }
}
