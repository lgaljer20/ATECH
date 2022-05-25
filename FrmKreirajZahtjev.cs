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

      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmKreirajZahtjev_Load(object sender, EventArgs e)
        {
            
            var izvori = IzvoriFinanciranjaRepository.DohvatiIzvore();
            cboIzvoriFinanciranja.DataSource = izvori;
        }

        private void cboIzvoriFinanciranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            var izvor = cboIzvoriFinanciranja.SelectedItem as IzvoriFinanciranja;
        }
    }
}
