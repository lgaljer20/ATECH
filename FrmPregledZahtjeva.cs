using ATECH.Models;
using ATECH.Repositories;
using DBLayer;
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
    public partial class FrmPregledZahtjeva : Form
    {
        public FrmPregledZahtjeva()
        {
            InitializeComponent();
        }

        private void FrmPregledZahtjeva_Load(object sender, EventArgs e)
        {
            PrikaziZahtjeve();
        }

        private void PrikaziZahtjeve()
        {
            var zahtjevi = ZahtjevRepository.DohvatiZahtjeve();
            dgvZahtjevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvZahtjevi.DataSource = zahtjevi;
            dgvZahtjevi.Columns[0].HeaderText = "Redni broj zahtjeva";
            dgvZahtjevi.Columns[1].HeaderText = "Naziv zahtjeva";
            dgvZahtjevi.Columns[2].HeaderText = "Naziv podnositelja zahtjeva";
            dgvZahtjevi.Columns[3].HeaderText = "Vrijeme kreiranja zahtjeva";
            dgvZahtjevi.Columns[4].HeaderText = "Izvor financiranja";
            dgvZahtjevi.Columns[5].HeaderText = "Opis zahtjeva";
            dgvZahtjevi.Columns[6].HeaderText = "Prvi ponuditelj";
            dgvZahtjevi.Columns[7].HeaderText = "Cijena bez PDV-a";
            dgvZahtjevi.Columns[8].HeaderText = "Cijena s PDV-om";
            dgvZahtjevi.Columns[9].HeaderText = "Da li je ponuda odobrena?";
            dgvZahtjevi.Columns[10].HeaderText = "Drugi ponuditelj";
            dgvZahtjevi.Columns[11].HeaderText = "Cijena bez PDV-a";
            dgvZahtjevi.Columns[12].HeaderText = "Cijena s PDV-om";
            dgvZahtjevi.Columns[13].HeaderText = "Da li je ponuda odobrena?";
            dgvZahtjevi.Columns[14].HeaderText = "Dodatna pojašnjenja";
            dgvZahtjevi.Columns[15].HeaderText = "Broj klase";
            dgvZahtjevi.Columns[16].HeaderText = "Urbroj";
        }
        

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            FrmPočetna frmPočetna = new FrmPočetna();
            Hide();
            frmPočetna.ShowDialog();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Zahtjev stisnutiZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            FrmAžurirajZahtjev frmAžuriraniZahtjev = new FrmAžurirajZahtjev(stisnutiZahtjev);

            Hide();
            frmAžuriraniZahtjev.ShowDialog();
            Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Zahtjev zahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            ZahtjevRepository.IzbrišiZahtjev(zahtjev);
            PrikaziZahtjeve();
            
        }

        private void txtPretraži_TextChanged(object sender, EventArgs e)
        {
            var zahtjeviPonuditelj = ZahtjevRepository.PretražiZahtjevPonuditelj(txtPonuditelj.Text);
            dgvZahtjevi.DataSource = zahtjeviPonuditelj;

        }

        private void txtNazivZahtjeva_TextChanged(object sender, EventArgs e)
        {
            var zahtjeviNaziv = ZahtjevRepository.PretražiNazivZahtjeva(txtNazivZahtjeva.Text);
            dgvZahtjevi.DataSource = zahtjeviNaziv;
        }   
    }
}
