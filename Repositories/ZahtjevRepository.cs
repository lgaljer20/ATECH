using ATECH.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATECH.Repositories
{
    public class ZahtjevRepository
    {

        public static List<Zahtjev> DohvatiZahtjeve()
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjev";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }

        private static Zahtjev CreateObject(System.Data.SqlClient.SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string naziv = reader["Naziv"].ToString();

            int idPodnositelja = int.Parse(reader["IdPodnositelja"].ToString());
            var korisnik = KorisnikRepository.DohvatiKorisnika(idPodnositelja); // korisnik je zapravo podnositelj

            DateTime vrijemeKreiranja = DateTime.Parse(reader["VrijemeKreiranja"].ToString()); // vjv ne radi

            int idFinanciranja = int.Parse(reader["IdFinanciranja"].ToString());
            var izvor = IzvoriFinanciranjaRepository.DohvatiIzvor(idFinanciranja);

            string opis = reader["Opis"].ToString();

            string ponuditeljPrvi = reader["PonuditeljPrvi"].ToString();
            float cijenaBezPrvi = float.Parse(reader["CijenaBezPrvi"].ToString());
            float cijenaPdvPrvi = float.Parse(reader["CijenaPdvPrvi"].ToString());
            bool ponudaPrvaOdobrena = reader["PonudaPrvaOdobrena"] as bool? ?? false;

            string ponuditeljDva = reader["PonuditeljDva"].ToString();
            float cijenaBezDva = float.Parse(reader["CijenaBezDva"].ToString());
            float cijenaPdvDva = float.Parse(reader["CijenaPdvDva"].ToString());
            bool ponudaDvaOdobrena = reader["PonudaDvaOdobrena"] as bool? ?? false;

            string dodatnaPojašnjenja = reader["DodatnaPojašnjenja"].ToString();
            int brojKlase = int.Parse(reader["BrojKlase"].ToString());
            int urbroj = int.Parse(reader["Urbroj"].ToString());

            var zahtjev = new Zahtjev
            {
                Id = id,
                Naziv = naziv,
                IdPodnositelja = korisnik,
                VrijemeKreiranja = vrijemeKreiranja,
                IdFinanciranja = izvor,
                Opis = opis,
                PonuditeljPrvi = ponuditeljPrvi,
                CijenaBezPrvi = cijenaBezPrvi,
                CijenaPdvPrvi = cijenaPdvPrvi,
                PonudaPrvaOdobrena = ponudaPrvaOdobrena,
                PonuditeljDva = ponuditeljDva,
                CijenaBezDva = cijenaBezDva,
                CijenaPdvDva = cijenaPdvDva,
                PonudaDvaOdobrena = ponudaDvaOdobrena,
                DodatnaPojašnjenja = dodatnaPojašnjenja,
                BrojKlase = brojKlase,
                Urbroj = urbroj
            };

            return zahtjev;
        }

        public static void KreirajZahtjev(string naziv, Korisnik korisnik, DateTime vrijeme, IzvoriFinanciranja izvor, string opis, string ponuditeljPrvi,
            float cijenaBezPrvi, float cijenaPrvi, bool prvaPonuda, string ponuditeljDva, float cijenaBezDva, float cijenaDva, bool drugaPonuda, string dodatnaPojašnjenja,
            int brojKlase, int urbroj)

        {
            string sql = $"INSERT INTO Zahtjev ( Naziv, IdPodnositelja, VrijemeKreiranja, IdFinanciranja, Opis, PonuditeljPrvi," +
                $" CijenaBezPrvi, CijenaPdvPrvi, PonudaPrvaOdobrena, PonuditeljDva, CijenaBezDva, CijenaPdvDva, PonudaDvaOdobrena," +
                $" DodatnaPojašnjenja, BrojKlase, Urbroj) VALUES ('{naziv}', {korisnik.Id}, '{vrijeme}', {izvor.Id}, '{opis}', " +
                $"'{ponuditeljPrvi}', {cijenaBezPrvi}, {cijenaPrvi}, '{prvaPonuda}', '{ponuditeljDva}', {cijenaBezDva}, {cijenaDva}," +
                $" '{drugaPonuda}', '{dodatnaPojašnjenja}', {brojKlase}, {urbroj})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }

        public static void AžurirajZahtjev(Zahtjev zahtjev, string naziv, IzvoriFinanciranja izvor, string opis, string ponuditeljPrvi,
            float cijenaBezPrvi, float cijenaPrvi, bool prvaPonuda, string ponuditeljDva, float cijenaBezDva, float cijenaDva, bool drugaPonuda, string dodatnaPojašnjenja,
            int brojKlase, int urbroj)
        {
            string sql = $"UPDATE Zahtjev SET Naziv = '{naziv}',  IdFinanciranja = {izvor.Id}, Opis = '{opis}', PonuditeljPrvi = '{ponuditeljPrvi}'," +
                $"CijenaBezPrvi ={cijenaBezPrvi}, CijenaPdvPrvi ={cijenaPrvi}, PonudaPrvaOdobrena = '{prvaPonuda}', PonuditeljDva  = '{ponuditeljDva}', CijenaBezDva = {cijenaBezDva}," +
                $"CijenaPdvDva = {cijenaDva}, PonudaDvaOdobrena = '{drugaPonuda}', DodatnaPojašnjenja = '{dodatnaPojašnjenja}', BrojKlase = {brojKlase}, Urbroj = {urbroj} WHERE Id = '{zahtjev.Id}'";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void IzbrišiZahtjev(Zahtjev zahtjev)
        {
            string sql = $"DELETE FROM Zahtjev WHERE Id = '{zahtjev.Id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Zahtjev> PretražiZahtjevPonuditelj(string text)
        {
            
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = "SELECT * FROM Zahtjev WHERE PonuditeljPrvi like '" + text + "%' OR PonuditeljDva like '" + text + "%' ";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }

        public static List<Zahtjev> PretražiNazivZahtjeva(string text)
        {

            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = "SELECT * FROM Zahtjev WHERE Naziv like '" + text+"%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }

 
    }

   }


