﻿using ATECH.Models;
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
        public static Zahtjev DohvatiZahtjev(Korisnik korisnik)
        {
            Zahtjev zahtjev = null;
            string sql = $"SELECT * FROM Zahtjev WHERE IdPodnositelja = {korisnik.Id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return zahtjev;
        }

        public static List<Zahtjev> DohvatiZahtjeve()
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjev";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while(reader.Read())
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

            DateTime vrijemeKreiranja = DateTime.Now; // vjv ne radi

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
            int urbroj =int.Parse(reader["Urbroj"].ToString());

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

          //  izvor.Id += 1;
          
            string sql = $"INSERT INTO Zahtjev ( Naziv, IdPodnositelja, VrijemeKreiranja, IdFinanciranja, Opis, PonuditeljPrvi," +
                $" CijenaBezPrvi, CijenaPdvPrvi, PonudaPrvaOdobrena, PonuditeljDva, CijenaBezDva, CijenaPdvDva, PonudaDvaOdobrena," +
                $" DodatnaPojašnjenja, BrojKlase, Urbroj) VALUES ('{naziv}', {korisnik.Id}, GETDATE(), {izvor.Id+1}, '{opis}', " +
                $"'{ponuditeljPrvi}', {cijenaBezPrvi}, {cijenaPrvi}, '{prvaPonuda}', '{ponuditeljDva}', {cijenaBezDva}, {cijenaDva}," +
                $" '{drugaPonuda}', '{dodatnaPojašnjenja}', {brojKlase}, {urbroj})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

     
        }

        public static void AžurirajZahtjev(string naziv,  IzvoriFinanciranja izvor, string opis, string ponuditeljPrvi,
            float cijenaBezPrvi, float cijenaPrvi, bool prvaPonuda, string ponuditeljDva, float cijenaBezDva, float cijenaDva, bool drugaPonuda, string dodatnaPojašnjenja,
            int brojKlase, int urbroj)
        {
            
            string sql = $"UPDATE Zahtjev SET Naziv = '{naziv}',  IdFinanciranja = {izvor.Id+1}, Opis = '{opis}', PonuditeljPrvi = '{ponuditeljPrvi}'," +
                $"CijenaBezPrvi ={cijenaBezPrvi}, CijenaPdvPrvi ={cijenaPrvi}, PonudaPrvaOdobrena = {prvaPonuda}, PonuditeljDva  = '{ponuditeljDva}', CijenaBezDva = {cijenaBezDva}," +
                $"CijenaPdvDva = {cijenaDva}, PonudaDvaOdobrena = {drugaPonuda}, DodatnaPojašnjenja = '{dodatnaPojašnjenja}', BrojKlase = {brojKlase}, Urbroj = {urbroj}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


       
         }
    }

