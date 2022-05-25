using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATECH.Models
{
    public class Zahtjev
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Korisnik IdPodnositelja { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public IzvoriFinanciranja IdFinanciranja { get; set; }
        public string Opis { get; set; }
        public string PonuditeljPrvi { get; set; }
        public float CijenaBezPrvi { get; set; }
        public float CijenaPdvPrvi { get; set; }
        public bool PonudaPrvaOdobrena { get; set; }
        public string PonuditeljDva { get; set; }
        public float CijenaBezDva{ get; set; }
        public float CijenaPdvDva { get; set; }
        public bool PonudaDvaOdobrena { get; set; }
        public string DodatnaPojašnjenja { get; set; }
        public int BrojKlase { get; set; }
        public int Urbroj { get; set; }




    }
}
