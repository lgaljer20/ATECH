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
    public partial class FrmAžurirajZahtjev : Form
    {

        private Zahtjev zahtjev;

        public Zahtjev StisnutiZahtjev { get => zahtjev; set => zahtjev = value; }

        public FrmAžurirajZahtjev(Zahtjev stisnutiZahtjev)
        {
            InitializeComponent();
            StisnutiZahtjev = stisnutiZahtjev;
        }

        private void FrmAžurirajZahtjev_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = StisnutiZahtjev.Naziv;
            txtKorisnik.Text = StisnutiZahtjev.IdPodnositelja.ToString();
            txtKlasa.Text = StisnutiZahtjev.BrojKlase.ToString();
            txtUrbroj.Text = StisnutiZahtjev.Urbroj.ToString();

            txtOpis.Text = StisnutiZahtjev.Opis.ToString();
            txtDodatno.Text = StisnutiZahtjev.DodatnaPojašnjenja.ToString();

            txtPonuditelj1.Text = StisnutiZahtjev.PonuditeljPrvi.ToString();
            txtCijenaBez1.Text = StisnutiZahtjev.CijenaBezPrvi.ToString();
            txtCijena1.Text = StisnutiZahtjev.CijenaPdvPrvi.ToString();

            txtPonuditelj2.Text = StisnutiZahtjev.PonuditeljDva.ToString();   
            txtCijenaBez2.Text = StisnutiZahtjev.CijenaBezDva.ToString();
            txtCijena2.Text = StisnutiZahtjev.CijenaPdvDva.ToString();

            checkBox2.Checked = StisnutiZahtjev.PonudaPrvaOdobrena;
            checkBox1.Checked = StisnutiZahtjev.PonudaDvaOdobrena;

            cboIzvoriFinanciranja.Text = StisnutiZahtjev.IdFinanciranja.ToString();
            txtVrijeme.Text = StisnutiZahtjev.VrijemeKreiranja.ToString();

    
            var izvori = IzvoriFinanciranjaRepository.DohvatiIzvore();
            cboIzvoriFinanciranja.DataSource = izvori;

        }
        private void PokreniPregledZahtjeva()
        {
            FrmPregledZahtjeva frmPregled = new FrmPregledZahtjeva();
            Hide();
            frmPregled.ShowDialog();
            Close();
        }

        private void btnAžurirajZahtjev_Click(object sender, EventArgs e)
        {

            var zahtjev = StisnutiZahtjev;
            
           
            var izvor = cboIzvoriFinanciranja.SelectedItem as IzvoriFinanciranja;
            String naziv = txtNaziv.Text;

            String opis = txtOpis.Text;
            String ponuditeljPrvi = txtPonuditelj1.Text;
            Boolean ponuda1 = checkBox2.Checked;
            Boolean ponuda2 = checkBox1.Checked;

            float cijenaBezPrvi;
            bool valid = float.TryParse(txtCijenaBez1.Text, out cijenaBezPrvi);

            float cijenaPdvPrvi;
            bool valid2 = float.TryParse(txtCijena1.Text, out cijenaPdvPrvi);


            string ponuditeljDva = txtPonuditelj2.Text;


            float cijenaBezDva;
            bool valid3 = float.TryParse(txtCijenaBez2.Text, out cijenaBezDva);


            float cijenaPdvDva;
            bool valid4 = float.TryParse(txtCijena2.Text, out cijenaPdvDva);

            string dodatnaPojašnjenja = txtDodatno.Text;

            int brojKlase;
            bool valid5 = int.TryParse(txtKlasa.Text, out brojKlase);
            int urbroj;
            bool valid6 = int.TryParse(txtUrbroj.Text, out urbroj);

            


            ZahtjevRepository.AžurirajZahtjev(zahtjev, naziv, izvor, opis, ponuditeljPrvi, cijenaBezPrvi, cijenaPdvPrvi, ponuda1, ponuditeljDva, cijenaBezDva, cijenaPdvDva,
                ponuda2, dodatnaPojašnjenja, brojKlase, urbroj);

            Close();
            PokreniPregledZahtjeva();
        }

        private void txtCijenaBez1_TextChanged_1(object sender, EventArgs e)
        {
            float cijenaBezPrvi;
            bool valid = float.TryParse(txtCijenaBez1.Text, out cijenaBezPrvi);
            float pdv = 1.25f;
            float cijenaPdv = cijenaBezPrvi * pdv;
            txtCijena1.Text = cijenaPdv.ToString();

        }

        private void txtCijena1_TextChanged_1(object sender, EventArgs e)
        {
            float pdv = 1.25f;
            float cijenaPdvPrvi;
            bool valid2 = float.TryParse(txtCijena1.Text, out cijenaPdvPrvi);
            float cijenaBez = cijenaPdvPrvi / pdv;
            txtCijenaBez1.Text = cijenaBez.ToString();
        }

        private void txtCijenaBez2_TextChanged_1(object sender, EventArgs e)
        {
            float cijenaBezDva;
            bool valid = float.TryParse(txtCijenaBez2.Text, out cijenaBezDva);
            float pdv = 1.25f;
            float cijenaPdv = cijenaBezDva * pdv;
            txtCijena2.Text = cijenaPdv.ToString();
        }

        private void txtCijena2_TextChanged_1(object sender, EventArgs e)
        {
            float pdv = 1.25f;
            float cijenaPdvDva;
            bool valid2 = float.TryParse(txtCijena2.Text, out cijenaPdvDva);
            float cijenaBez = cijenaPdvDva / pdv;
            txtCijenaBez2.Text = cijenaBez.ToString();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            PokreniPregledZahtjeva();
        }
    }
}
