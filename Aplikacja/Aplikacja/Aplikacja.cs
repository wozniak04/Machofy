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
        public Aplikacja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tWyszukaj.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("./musics/Havana.mp3");
            splayer.Play();
        }
    }
}
