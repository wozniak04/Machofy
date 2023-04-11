using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Aplikacja
{

    public partial class Aplikacja : Form
    {
        private string nazwa;
        public Aplikacja(string nazwa)
        {
            this.nazwa = nazwa;
            InitializeComponent();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {

            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.FlatAppearance.BorderSize = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            btn_play.FlatStyle = FlatStyle.Flat;
            btn_play.FlatAppearance.BorderSize = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.FlatAppearance.BorderSize = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            btn_forward.FlatStyle = FlatStyle.Flat;
            btn_forward.FlatAppearance.BorderSize = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            btn_like.FlatStyle = FlatStyle.Flat;
            btn_like.FlatAppearance.BorderSize = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            btn_serce.FlatStyle = FlatStyle.Flat;
            btn_serce.FlatAppearance.BorderSize = 0;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tWyszukaj.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("./Resources/Musics/Havana.mp3");
            splayer.Play();
            odtwarzana_muzyka.Text = "Havana";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
