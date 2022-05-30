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
    public partial class FrmLogin : Form
    {  
        public static Korisnik PrijavljenKorisnik { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }
     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                PrijavljenKorisnik = KorisnikRepository.DohvatiKorisnika(txtUsername.Text);
                if (PrijavljenKorisnik != null && PrijavljenKorisnik.Lozinka == txtPassword.Text)
                {
                    FrmPočetna frmPočetna = new FrmPočetna();
                    Hide();
                    frmPočetna.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }


}
