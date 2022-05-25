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
    public partial class FrmPočetna : Form
    {
        public FrmPočetna()
        {
            InitializeComponent();
        }

        private void FrmPočetna_Load(object sender, EventArgs e)
        {
            ShowKorisnik();
        }

        private void ShowKorisnik()
        {
            var korisnici = KorisnikRepository.DohvatiKorisnike();
            dgvKorisnik.DataSource = korisnici;

            dgvKorisnik.Columns["Ime"].DisplayIndex = 0;
            dgvKorisnik.Columns["Prezime"].DisplayIndex = 1;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmKreirajZahtjev frmZahtjev = new FrmKreirajZahtjev();
            Hide();
            frmZahtjev.ShowDialog();
            Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void labelPregledajZahtjeve_Click(object sender, EventArgs e)
        {
            FrmPregledZahtjeva frmPregledajZahtjev= new FrmPregledZahtjeva();
            Hide();
            frmPregledajZahtjev.ShowDialog();
            Close();
        }
    }
}
