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
    public partial class DoktorForm : BaseForm
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        public List<Doktorlar> Doktorlar { get; set; }
        public List<Hemsireler> Hemsireler { get; set; }
        private void Doktor_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(Doktorlar.Branslar)));
            //cmbHemsire.Items.AddRange()
            ListeyiDoldur();
        }
        void ListeyiDoldur()
        {
            lstKisi.Items.Clear();
            foreach (Doktorlar item in Doktorlar)
            {
                lstKisi.Items.Add(item);
            }
        }
        Doktorlar seciliDoktor;
        Hemsireler seciliHemsire;
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            
            try
            {

                

                seciliHemsire = lstHemsire.SelectedItem as Hemsireler;
                

                Button senderr = sender as Button;
                if (senderr.Text == "Kaydet")
                {

                    Doktorlar yeniDoktor = new Doktorlar()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                        DogumTarihi = dtpDogumTarihi.Value,
                        Tckn = txtTCKN.Text,
                        Maas = Convert.ToDecimal(txtMaas.Text),
                        Branslar1 = (Doktorlar.Branslar)Enum.Parse(typeof(Doktorlar.Branslar), cmbBrans.SelectedItem.ToString()),
                    };
                    foreach (Hemsireler item in lstHemsire.SelectedItems)
                    {
                        yeniDoktor.DoktorunHemsiresi.Add(item);
                    }
                    seciliHemsire.bosMu = false;
                    this.Doktorlar.Add(yeniDoktor);
                    MessageBox.Show("Doktor Ekleme işlemi Başarılı");
                    hemsireListesiniDoldur();
                    ListeyiDoldur();
                    FormuTemizle();
                }
                else if (senderr.Text=="Güncelle")
                {
                    if (seciliDoktor == null)
                    {
                        MessageBox.Show("Lütfen güncellenecek Personeli Seçiniz");
                        return;
                    }
                    seciliDoktor = Doktorlar.Where(item => item.Tckn == seciliDoktor.Tckn).FirstOrDefault();
                    seciliDoktor.Ad = txtAd.Text;
                    seciliDoktor.Soyad = txtSoyad.Text;
                    seciliDoktor.Tckn = txtTCKN.Text;
                    seciliDoktor.DogumTarihi = dtpDogumTarihi.Value;
                    seciliDoktor.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                    ListeyiDoldur();
                    seciliDoktor = null;
                    foreach (Hemsireler item in lstHemsire.SelectedItems)
                    {
                        seciliDoktor.DoktorunHemsiresi.Add(item);
                    }
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
            seciliDoktor = lstKisi.SelectedItem as Doktorlar;

            DialogResult cevap = MessageBox.Show($"{seciliDoktor.Ad} adlı kişiyi silmek istiyor musunuz", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                
                Doktorlar.Remove(seciliDoktor);
                ListeyiDoldur();
                //FormuTemizle();
                MessageBox.Show($"{seciliDoktor.Ad} adlı kişi silindi");
                foreach (var item in lstHemsire.Items)
                {
                    (item as Hemsireler).bosMu = true;
                }
                seciliDoktor = null;
                btnKaydet.Text = "Kaydet";

            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Doktorlar> aramaSonucu = MyTool<Doktorlar>.Ara(Doktorlar, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            hemsireListesiniDoldur();
             }

        private void hemsireListesiniDoldur()
        {
            lstHemsire.Items.Clear();

            lstHemsire.Items.AddRange((MyBronsaGoreHemsire.hemsireSecimi((Hemsireler.Where(x => x.bosMu == true).ToList()), Convert.ToString(cmbBrans.SelectedItem))).ToArray());

        }

        private void ListeyiDoldur(List<Doktorlar> aramaSonucu)
        {
            lstKisi.Items.Clear();
            foreach (Doktorlar item in aramaSonucu)
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
            seciliDoktor = lstKisi.SelectedItem as Doktorlar;
            txtAd.Text = seciliDoktor.Ad;
            txtSoyad.Text = seciliDoktor.Soyad;
            txtTCKN.Text = seciliDoktor.Tckn;
            dtpDogumTarihi.Value = seciliDoktor.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliDoktor.Cinsiyet;
            txtMaas.Text = seciliDoktor.Maas.ToString();
            cmbBrans.SelectedIndex = (int)seciliDoktor.Branslar1;
            foreach (Hemsireler item in seciliDoktor.DoktorunHemsiresi)
            {
                lstHemsire.Items.Add(item);
            }
            
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
        private void DoktorForm_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                    btnKaydet.PerformClick();
        }
        private void DoktorForm_MouseClick(object sender, MouseEventArgs e)
        {
            btnKaydet.Text = "Kaydet";
            lstKisi.SelectedIndex = -1;
        }
    }
}
