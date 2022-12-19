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
    public partial class IK : Form
    {
        int[] maaslar;
        string[] calisanlar;
        public IK()
        {
            InitializeComponent();
        }

        private void btn_KaydetGoster_Click(object sender, EventArgs e)
        {
            lbox_Liste.Items.Clear();
            calisanlar = new string[]{ "Ahmet", "Mehmet", "Deniz" ,"Ali"};
            maaslar = new int[] { 6000, 1000, 3000, 8000};
            for(int i = 0; i < calisanlar.Length; i++)
            {
                lbox_Liste.Items.Add(calisanlar[i] + "\t" + maaslar[i]);
            }
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            string personel = txt_Calisan.Text;
            for (int i = 0; i < calisanlar.Length; i++)
            {
                if(personel == calisanlar[i])
                {
                    MessageBox.Show("Aradığınız Değer Bulundu. => " + personel);
                    break;
                }
                else
                {
                    MessageBox.Show("Aradığınız Değer Bulunamadı. => " + personel);
                }
            }
        }

        private void btn_KaydiGetir_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= calisanlar.Length-1; i++)
            {
                for(int j = 0; j<= maaslar.Length-1; j++)
                {
                    txt_SonKayit.Text = calisanlar[i] + " " + maaslar[j];
                }
            }      
        }

        private void btn_Gelir_Click(object sender, EventArgs e)
        {
            int enbuyuk = 0;
            for (int i = 0; i <= maaslar.Length-1; i++)
            {
                if (maaslar[i] > enbuyuk)
                {
                    enbuyuk = maaslar[i];
                    txt_Gelir.Text = "En yüksek maaş " + enbuyuk.ToString();
                }
            }
        }

        public string GiristenGelenVeri = " ";
        private void IK_Load(object sender, EventArgs e)
        {
            lbl_Mesaj.Text = GiristenGelenVeri;
        }
    }
}
