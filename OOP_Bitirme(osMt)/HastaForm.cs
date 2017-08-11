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
    public partial class HastaForm : BaseForm
    {
        public HastaForm()
        {
            InitializeComponent();
        }

        public List<Hastalar> hastalar { get; set; }
         private void HastaForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            ListeyiDoldur();
        }
        void ListeyiDoldur()
        {
            lstKisi.Items.Clear();
            foreach (Hastalar item in hastalar)
            {
                lstKisi.Items.Add(item);
            }
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Button senderr = sender as Button;
                if (senderr.Text == "Kaydet")
                {

                    Hastalar yeniHasta = new Hastalar()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                        DogumTarihi = dtpDogumTarihi.Value,
                        Tckn = txtTCKN.Text
                        
                    };
                    
                    this.hastalar.Add(yeniHasta);
                    ListeyiDoldur();
                    MessageBox.Show("Hasta Ekleme işlemi Başarılı");
                    FormuTemizle();

                }
                else if (senderr.Text == "Güncelle")
                {
                    if (seciliHasta == null)
                    {
                        MessageBox.Show("Güncellenecek İsmi seçiniz");
                        return;
                    }
                    seciliHasta = hastalar.Where(item => item.Tckn == seciliHasta.Tckn).FirstOrDefault();
                    seciliHasta.Ad = txtAd.Text;
                    seciliHasta.Soyad = txtSoyad.Text;
                    seciliHasta.Tckn = txtTCKN.Text;
                    seciliHasta.DogumTarihi = dtpDogumTarihi.Value;
                    seciliHasta.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                    ListeyiDoldur();
                    seciliHasta = null;
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
        Hastalar seciliHasta;
        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedIndex == -1)
            {
                btnKaydet.Text = "Kaydet";
                return;
            }
            seciliHasta = lstKisi.SelectedItem as Hastalar;
            txtAd.Text = seciliHasta.Ad;
            txtSoyad.Text = seciliHasta.Soyad;
            txtTCKN.Text = seciliHasta.Tckn;
            dtpDogumTarihi.Value = seciliHasta.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliHasta.Cinsiyet;
            btnKaydet.Text = "Güncelle";

            
        }
        
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisi.SelectedItem == null)
            {
                MessageBox.Show("neyi sileyim?"); return;
            }
            seciliHasta = lstKisi.SelectedItem as Hastalar;

            DialogResult cevap = MessageBox.Show($"{seciliHasta.Ad} adlı kişiyi silmek istiyor musunuz", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                hastalar.Remove(seciliHasta);
                ListeyiDoldur();
                FormuTemizle();
                MessageBox.Show($"{seciliHasta.Ad} adlı kişi silindi");
                seciliHasta = null;
                btnKaydet.Text = "Kaydet";
                
            }
        }
        private void ListeyiDoldur(List<Hastalar> aramaSonucu)
        {
            lstKisi.Items.Clear();
            foreach (Hastalar item in aramaSonucu)
            {
                lstKisi.Items.Add(item);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hastalar> aramaSonucu = MyTool<Hastalar>.Ara(hastalar, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }

        private void HastaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKaydet.PerformClick();
        }

        private void HastaForm_MouseClick_1(object sender, MouseEventArgs e)
        {
            btnKaydet.Text = "Kaydet";
            lstKisi.SelectedIndex = -1;
        }
    }
}
