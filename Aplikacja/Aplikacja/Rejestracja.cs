using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (Regex.IsMatch(tEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                if (Regex.IsMatch(tHaslo1.Text, @".{8,}"))
                {
                    if (tHaslo1.Text.ToString().Equals(tHaslo2.Text.ToString()))
                    {
                        var pol = new DataAcces();
                        string haslo = BCrypt.Net.BCrypt.HashPassword(tHaslo1.Text.ToString());
                        string dane = pol.Rejestracja(tEmail.Text, haslo);
                        if (dane == "")
                        {
                            
                            var okno = new Aplikacja(tEmail.Text.ToString());
                            this.Hide();
                            okno.ShowDialog();
                            this.Close();
                        }else
                        {
                            MessageBox.Show(dane);
                        }
                    }else
                    {
                        MessageBox.Show("hasła różnią się");
                    }
                }
                else
                {
                    MessageBox.Show("hasło powinno zawierać conajmniej 8 znaków");
                }
            }
            else
            {
                MessageBox.Show("zły email");
            }
        }
    }
}
