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
    }
}
