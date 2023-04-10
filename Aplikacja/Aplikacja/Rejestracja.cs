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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnRejestruj.FlatStyle = FlatStyle.Flat;
            btnRejestruj.FlatAppearance.BorderSize = 0;

            if (tHaslo1.Text.ToString().Equals(tHaslo2.Text.ToString()))
            {
                var pol = new DataAcces();
                string haslo = BCrypt.Net.BCrypt.HashPassword(tHaslo1.Text.ToString());
                if(pol.Rejestracja(tEmail.Text, haslo))
                {
                    MessageBox.Show("Zarejestrowano pomyślnie");
                    var okno = new Aplikacja(tEmail.Text.ToString());
                    this.Hide();
                    okno.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rejestracja nie powiodła się");
                }
            }
        }
    }
}
