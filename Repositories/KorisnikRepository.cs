using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATECH.Models;
using DBLayer;

namespace ATECH.Repositories
{

    public class KorisnikRepository
    {
       
        public static Korisnik DohvatiKorisnika(string username)
        {
            string sql = $"SELECT * FROM Korisnik WHERE KorisnickoIme = '{username}'";
            return Dohvati(sql);
        }
        public static Korisnik DohvatiKorisnika(int id)
        {
            string sql = $"SELECT * FROM Korisnik WHERE Id = {id}";
            return Dohvati(sql);
        }
        
        private static Korisnik Dohvati(string sql)
        {
            
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Korisnik korisnik = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return korisnik;
        }

        public static List<Korisnik> DohvatiKorisnike()
        {
            var korisnici = new List<Korisnik>();

            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Korisnik korisnik = CreateObject(reader);
                korisnici.Add(korisnik);
            }

            reader.Close();
            DB.CloseConnection();

            return korisnici;
        }

        private static Korisnik CreateObject(System.Data.SqlClient.SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string mail = reader["Mail"].ToString();
            var korisnik = new Korisnik
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = korisnickoIme,
                Lozinka = lozinka,
                Mail = mail
            };

            return korisnik;
        }
    }
}
