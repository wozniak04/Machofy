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
            var pol = new DataAcces();
            string haslo = BCrypt.Net.BCrypt.HashPassword(tHaslo.Text, 10);


            if (pol.Logowanie(tEmail.Text, tHaslo.Text)) 
            {
                var okno = new Aplikacja(tEmail.Text);
                this.Hide();
                okno.ShowDialog();
                this.Close();
            }
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

        private void tEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
