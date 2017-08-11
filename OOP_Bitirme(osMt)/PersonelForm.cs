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
    public partial class PersonelForm : BaseForm
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbGorev.Items.AddRange(Enum.GetNames(typeof(Personeller.Gorevler)));

        }
        public List<Personeller> Personeller { get; set; }

        void ListeyiDoldur()
        {
            lstKisi.Items.Clear();
            foreach (Personeller item in Personeller)
            {
                lstKisi.Items.Add(item);
            }
        }

        Personeller seciliPersonel;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Button senderr = sender as Button;
                if (senderr.Text=="Kaydet")
                {
                    Personeller yeniPersonel = new Personeller()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                        DogumTarihi = dtpDogumTarihi.Value,
                        Tckn = txtTCKN.Text,
                        Maas = Convert.ToDecimal(txtMaas.Text),
                        Gorevler1 = (Personeller.Gorevler)Enum.Parse(typeof(Personeller.Gorevler), cmbGorev.SelectedItem.ToString())


                    };
                    this.Personeller.Add(yeniPersonel);
                    ListeyiDoldur();
                    MessageBox.Show("Personel Ekleme işlemi Başarılı");
                }
                else if (senderr.Text=="Güncelle")
                {
                    if (seciliPersonel==null)
                    {
                        MessageBox.Show("Lütfen güncellenecek Personeli Seçiniz");
                        return;
                    }
                    seciliPersonel = Personeller.Where(item => item.Tckn == seciliPersonel.Tckn).FirstOrDefault();
                    seciliPersonel.Ad = txtAd.Text;
                    seciliPersonel.Soyad = txtSoyad.Text;
                    seciliPersonel.Tckn = txtTCKN.Text;
                    seciliPersonel.DogumTarihi = dtpDogumTarihi.Value;
                    seciliPersonel.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                    ListeyiDoldur();
                    seciliPersonel = null;
                    btnKaydet.Text = "Kaydet";
                    MessageBox.Show("Güncelleme Başarılı");
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
            seciliPersonel = lstKisi.SelectedItem as Personeller;

            DialogResult cevap = MessageBox.Show($"{seciliPersonel.Ad} adlı kişiyi silmek istiyor musunuz", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Personeller.Remove(seciliPersonel);
                ListeyiDoldur();
                //FormuTemizle();
                MessageBox.Show($"{seciliPersonel.Ad} adlı kişi silindi");
                seciliPersonel = null;
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
            seciliPersonel = lstKisi.SelectedItem as Personeller;
            txtAd.Text = seciliPersonel.Ad;
            txtSoyad.Text = seciliPersonel.Soyad;
            txtTCKN.Text = seciliPersonel.Tckn;
            dtpDogumTarihi.Value = seciliPersonel.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliPersonel.Cinsiyet;
            txtMaas.Text = seciliPersonel.Maas.ToString();
            cmbGorev.SelectedIndex = (int)seciliPersonel.Gorevler1;
            btnKaydet.Text = "Güncelle";
        }
        
        private void FormuTemizle()
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

        private void PersonelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKaydet.PerformClick();
        }

        private void PersonelForm_MouseClick(object sender, MouseEventArgs e)
        {
            btnKaydet.Text = "Kaydet";
            lstKisi.SelectedIndex = -1;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Personeller> aramaSonucu = MyTool<Personeller>.Ara(Personeller, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
    }
}
