using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aplikacja
{
    class DataAcces
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Baza.mdf" + ";Integrated Security=True;");

        public bool Rejestracja(string email,string haslo)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Uzytkownicy (Email,Haslo) VALUES (@email,@haslo);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@haslo", haslo);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Logowanie(string email,string haslo)
        {
            conn.Open();
            string query = "SELECT Haslo FROM Uzytkownicy WHERE Email=@email;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            string hashpass = "";
            if (rdr.Read())
            {
                hashpass = rdr["Haslo"].ToString();
            }
            conn.Close();

            if (BCrypt.Net.BCrypt.Verify(haslo, hashpass))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool dodajUlubienie(string email,string muzyka)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Email,Muzyka FROM Ulubione WHERE Email=@email AND Muzyka=@muzyka;", conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@muzyka", muzyka);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdr.Close();
                    conn.Close();
                    return true;
                }
                rdr.Close();
                cmd = new SqlCommand("INSERT INTO Ulubione (Email,Muzyka) VALUES (@email,@muzyka);", conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@muzyka", muzyka);
                cmd.ExecuteNonQuery();
                conn.Close();
            }catch
            {
                return false;
            }
            return true;

        }
        public bool Ulubione(string email,string muzyka)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Muzyka FROM Ulubione WHERE Email=@email AND Muzyka=@muzyka;", conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@muzyka", muzyka);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
            }
            catch
            {
                return false;
            }
            return false;
        }
        public bool UsunUlubione(string email,string muzyka)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Ulubione WHERE Email=@email AND Muzyka=@muzyka;", conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@muzyka", muzyka);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}
