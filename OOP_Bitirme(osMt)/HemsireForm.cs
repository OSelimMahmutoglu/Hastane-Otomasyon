using HastaneKutuphane;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Bitirme_osMt_
{
    public partial class HemsireForm : BaseForm
    {
        public HemsireForm()
        {
            InitializeComponent();
        }
        public List<Hemsireler> hemsireler { get; set; }
        private void Hemsire_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(HBranslar)));
            ListeyiDoldur();
        }
        void ListeyiDoldur()
        {
            lstKisi.Items.Clear();
            foreach (Hemsireler item in hemsireler)
            {
                lstKisi.Items.Add(item);
            }
        }

        Hemsireler seciliHemsire;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Button senderr = sender as Button;
                if (senderr.Text == "Kaydet")
                {
                    Hemsireler yeniHemsire = new Hemsireler()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                        DogumTarihi = dtpDogumTarihi.Value,
                        Tckn = txtTCKN.Text,
                        Maas = Convert.ToDecimal(txtMaas.Text),
                        HBranslar = (HBranslar)Enum.Parse(typeof(HBranslar), cmbBrans.SelectedItem.ToString())
                    };
                    this.hemsireler.Add(yeniHemsire);
                    ListeyiDoldur();
                    FormuTemizle();
                    MessageBox.Show("Hemsire Ekleme işlemi Başarılı");
                    
                }
                else if (senderr.Text == "Güncelle")
                {
                    if (seciliHemsire == null)
                    {
                        MessageBox.Show("Lütfen güncellenecek Personeli Seçiniz");
                        return;
                    }
                    seciliHemsire = hemsireler.Where(item => item.Tckn == seciliHemsire.Tckn).FirstOrDefault();
                    seciliHemsire.Ad = txtAd.Text;
                    seciliHemsire.Soyad = txtSoyad.Text;
                    seciliHemsire.Tckn = txtTCKN.Text;
                    seciliHemsire.DogumTarihi = dtpDogumTarihi.Value;
                    seciliHemsire.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                    ListeyiDoldur();
                    seciliHemsire = null;
                    btnKaydet.Text = "Kaydet";
                    MessageBox.Show("Güncelleme Başarılı");
                    FormuTemizle();
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisi.SelectedItem == null)
            {
                MessageBox.Show("neyi sileyim?"); return;
            }
            seciliHemsire = lstKisi.SelectedItem as Hemsireler;

            DialogResult cevap = MessageBox.Show($"{seciliHemsire.Ad} adlı kişiyi silmek istiyor musunuz", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                hemsireler.Remove(seciliHemsire);
                ListeyiDoldur();
                FormuTemizle();
                MessageBox.Show($"{seciliHemsire.Ad} adlı kişi silindi");
                seciliHemsire = null;
                btnKaydet.Text = "Kaydet";

            }
        }
        private void ListeyiDoldur(List<Personeller> aramaSonucu)
        {
            lstKisi.Items.Clear();
            foreach (Personeller item in aramaSonucu)
            {
                lstKisi.Items.Add(item);
            }
        }

        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedIndex == -1)
            {
                btnKaydet.Text = "Kaydet";
                return;
            }
            seciliHemsire = lstKisi.SelectedItem as Hemsireler;
            txtAd.Text = seciliHemsire.Ad;
            txtSoyad.Text = seciliHemsire.Soyad;
            txtTCKN.Text = seciliHemsire.Tckn;
            dtpDogumTarihi.Value = seciliHemsire.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliHemsire.Cinsiyet;
            txtMaas.Text = seciliHemsire.Maas.ToString();
            cmbBrans.SelectedIndex = (int)seciliHemsire.HBranslar;
            btnKaydet.Text = "Güncelle";
        }
        void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
            }

        }

        private void HemsireForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKaydet.PerformClick();
        }

        private void HemsireForm_MouseClick(object sender, MouseEventArgs e)
        {
            btnKaydet.Text = "Kaydet";
            lstKisi.SelectedIndex = -1;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArama_TextChanged_1(object sender, EventArgs e)
        {
            List<Hemsireler> aramaSonucu = MyTool<Hemsireler>.Ara(hemsireler, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
        private void ListeyiDoldur(List<Hemsireler> aramaSonucu)
        {
            lstKisi.Items.Clear();
            foreach (Hemsireler item in aramaSonucu)
            {
                lstKisi.Items.Add(item);
            }
        }
    }
}
