﻿using ATECH.Models;
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
            dgvZahtjevi.DataSource = zahtjevi;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            FrmPočetna frmPočetna = new FrmPočetna();
            Hide();
            frmPočetna.ShowDialog();
            Close();
        }

        private void dgvZahtjevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Zahtjev stisnutiZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            FrmAžurirajZahtjev frmAžuriraniZahtjev = new FrmAžurirajZahtjev(stisnutiZahtjev);
            frmAžuriraniZahtjev.ShowDialog();

        }
    }
}
