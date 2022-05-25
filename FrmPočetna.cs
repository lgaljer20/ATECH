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
    public partial class FrmPočetna : Form
    {
        public FrmPočetna()
        {
            InitializeComponent();
        }

        private void FrmPočetna_Load(object sender, EventArgs e)
        {
            string ime= FrmLogin.PrijavljenKorisnik.Ime;
            label3.Text = ime;
            string prezime = FrmLogin.PrijavljenKorisnik.Prezime;
            label4.Text = prezime;
            string mail = FrmLogin.PrijavljenKorisnik.Mail;
            label5.Text = mail;

            pbx1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx1.Image = Properties.Resources.ATECH;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
