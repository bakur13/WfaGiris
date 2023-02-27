using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaGiris
{
    public partial class FormKisiler : Form
    {
        public FormKisiler()
        {
            InitializeComponent();
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                /*
                Kisi kisi = new Kisi();
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                kisi.Tckn = txtEmail.Text;
                kisi.DogumTarihi = dtpDogumTarihi.Value;
                kisi.Telefon = txtTelefon.Text;
                kisi.Email = txtEmail.Text;
                */

                Kisi kisi = new Kisi()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Email = txtEmail.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Tckn = txtTckn.Text,
                    Telefon = txtTelefon.Text

                };
               // lstKisiler.DisplayMember = "Ad";
                MessageBox.Show(kisi.ToString());

                lstKisiler.Items.Add(kisi);


            }
            catch (Exception ex)
            {
                MessageBox.Show($" Bir Hata Oluştu{ex.Message}");
            }
        }

        public void FormuTemizle()
        {
            /*
            txtAd.Text = String.Empty;
            txtEmail.Text = String.Empty;
            
            */

            foreach(Control item in this.Controls)
            {
                item.Text = String.Empty;
            }
        }
    }
}
