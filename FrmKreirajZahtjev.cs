using ATECH.Models;
using ATECH.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATECH
{
    public partial class FrmKreirajZahtjev : Form
    {

        public FrmKreirajZahtjev()
        {
            InitializeComponent();
        }

        private void FrmKreirajZahtjev_Load(object sender, EventArgs e)
        {
            txtVrijeme.Text = DateTime.Now.ToString();
            txtKorisnik.Text = FrmLogin.PrijavljenKorisnik.ToString();
            var izvori = IzvoriFinanciranjaRepository.DohvatiIzvore();
            cboIzvoriFinanciranja.DataSource = izvori;
        }

        private void cboIzvoriFinanciranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            var izvor = cboIzvoriFinanciranja.SelectedItem as IzvoriFinanciranja;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            PokreniPočetnu();
        }

        private void PokreniPočetnu()
        {
            FrmPočetna frmPočetna = new FrmPočetna();
            Hide();
            frmPočetna.ShowDialog();
            Close();
        }

        private void btnKreirajZahtjev_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            var korisnik = FrmLogin.PrijavljenKorisnik;
            DateTime vrijeme = DateTime.Now;
            var izvor = cboIzvoriFinanciranja.SelectedItem as IzvoriFinanciranja; 
       

            String opis = txtOpis.Text;
            String ponuditeljPrvi = txtPonuditelj1.Text;
            Boolean ponuda1 = checkBox1.Checked;
            Boolean ponuda2 = checkBox2.Checked;

            float cijenaBezPrvi;
            bool valid = float.TryParse(txtCijenaBez1.Text, out cijenaBezPrvi);

            float cijenaPdvPrvi;
            bool valid2 = float.TryParse(txtCijena1.Text, out cijenaPdvPrvi);


            string ponuditeljDva= txtPonuditelj2.Text;


            float cijenaBezDva;
            bool valid3= float.TryParse(txtCijenaBez2.Text, out cijenaBezDva);


            float cijenaPdvDva;
            bool valid4= float.TryParse(txtCijena2.Text, out cijenaPdvDva);
        
            string dodatnaPojašnjenja = txtDodatno.Text;

            int brojKlase;
            bool valid5 = int.TryParse(txtKlasa.Text, out brojKlase);
            int urbroj;
            bool valid6 = int.TryParse(txtUrbroj.Text, out urbroj);
       
            ZahtjevRepository.KreirajZahtjev(naziv, korisnik, vrijeme, izvor, opis, ponuditeljPrvi,
                cijenaBezPrvi, cijenaPdvPrvi, ponuda1, ponuditeljDva, cijenaBezDva, cijenaPdvDva,
                ponuda2, dodatnaPojašnjenja, brojKlase, urbroj);
            PokreniPočetnu();

        }
    }
}
