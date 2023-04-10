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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string haslo = BCrypt.Net.BCrypt.HashPassword(tHaslo.Text.ToString());
            MessageBox.Show(BCrypt.Net.BCrypt.Verify("Qwerty1@3",haslo).ToString());
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void btnRejestruj_Click(object sender, EventArgs e)
        {
            var okno = new Rejestracja();
            this.Hide();
            okno.ShowDialog();    
            this.Close();
        }
    }
}
