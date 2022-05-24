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
            string sql = $"SELECT * FROM Students WHERE Id = {id}";
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




        // DB.SetConfiguration("lgaljer20_DB", "lgaljer20", ")lA00rOP")
        /*  public static Korisnik DohvatiKorisnika(int id)
          {
              Korisnik korisnik = null;
              string sql = $"SELECT * FROM Korisnik WHERE Id = {id}";
              DB.OpenConnection();
              var reader = DB.GetDataReader(sql);
              if (reader.HasRows)
              {
                  reader.Read();
                  korisnik = CreateObject(reader);
                  reader.Close();
              }

              DB.CloseConnection();
              return korisnik;
          }
        */
        private static Korisnik CreateObject(System.Data.SqlClient.SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            var korisnik = new Korisnik
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = korisnickoIme,
                Lozinka = lozinka
            };

            return korisnik;
        }
    }
}
