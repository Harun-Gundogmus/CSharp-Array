using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciadi = "admin";
            string sifre = "1234";
            string alinankAdi = txt_KullanciAdi.Text;
            string alinansifre = txt_Sifre.Text;

            if (kullaniciadi == alinankAdi && sifre == alinansifre)
            {
                MessageBox.Show("Giriş Başarılı Hoşgeldin " + kullaniciadi);
                this.Hide();
                IK ikformu = new IK();
                ikformu.GiristenGelenVeri = "HOŞGELDİN " + kullaniciadi;
                ikformu.Show();
                
            }
            else
                MessageBox.Show("Giriş Başarısız");
        }
    }
    
}
