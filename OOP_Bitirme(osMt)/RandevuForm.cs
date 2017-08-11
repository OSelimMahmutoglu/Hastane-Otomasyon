using HastaneKutuphane;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Bitirme_osMt_
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }
        public List<Randevu> randevular = new List<Randevu>();
        public List<Hastalar> hastalar { get; set; }
        public List<Doktorlar> doktorlar { get; set; }
        

        private void lbHastaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliHasta = lstKisi.SelectedItem as Hastalar;
            butonPasifYap(seciliHasta.RandevuSaatleri);
        }
        Context context = new Context();

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(Doktorlar.Branslar)));
            ListeyiDoldur();
            butonlarıAktifYap();

        }
        void butonlarıAktifYap()
        {
            foreach (var item in gbSaatler.Controls)
            {
                if (item is Button)
                {
                    (item as Button).Enabled = true;
                    (item as Button).BackColor = Color.FromArgb(128, 255, 128);
                }
                    
            }
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
                    (item as ComboBox).SelectedIndex = -1;
                else if (item is ListBox)
                    (item as ListBox).SelectedIndex = -1;
            }
            cmbBrans.SelectedIndex = -1;
            
        }
        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            Form1 anaform =(Form1) this.MdiParent;
            anaform.hastaİşlemleriToolStripMenuItem_Click(sender, e); // burada randevu listesinden hasta ekleye bastığımızda form1 in içindeki hasta ekle butonunu click ettik. 
        }
        Hastalar seciliHasta;
        Doktorlar seciliDoktor;
        string saat;
       

        private void button12_Click(object sender, EventArgs e)
        {
            Button tiklama = sender as Button;
            saat = tiklama.Text;
            foreach (var item in gbSaatler.Controls)
            {
                if(item is Button)
                {
                    (item as Button).BackColor = Color.FromArgb(128, 255, 128);
                }
            }
            tiklama.BackColor = Color.Black;
        }
        void butonPasifYap(List<string> saatler)
        {
            foreach (var saati in saatler)
            {
                foreach (var item in gbSaatler.Controls)
                {
                    if (item is Button)
                    {
                        if ((item as Button).Text == saati)
                        {
                            (item as Button).Enabled = false;
                        }
                    }
                }
            }
        }
        private void btnListeyiGuncelle_Click(object sender, EventArgs e)
        {
            lstKisi.Items.Clear();
            foreach (Hastalar item in hastalar)
            {
                lstKisi.Items.Add(item);
            }
        }

        

      

        private void btnRandevuyuKaydet_Click_1(object sender, EventArgs e)
        {
            if (saat == null)
            {
                MessageBox.Show("Randevu saatini seçmelisiniz");
                return;
            }
            if (seciliHasta == null)
            {
                MessageBox.Show("hangi hasta için randevu almaya çalışıyorsunuz");
                return;
            }

            seciliHasta.RandevuSaatleri.Add(saat);
            Randevu yeniRandevu = new Randevu()
            {
                Ad = seciliHasta.Ad,
                Soyad = seciliHasta.Soyad,
                DogumTarihi = seciliHasta.DogumTarihi,
                Cinsiyet = seciliHasta.Cinsiyet,
                Tckn = seciliHasta.Tckn,
                RandevuSaatleri = seciliHasta.RandevuSaatleri,
                DoktorAdi = cmbDoktor.SelectedItem.ToString(),
                RandevuKlinigi = cmbBrans.SelectedItem.ToString()
            };
            seciliHasta.RandevuSaatleri.Add(saat);
            seciliDoktor.DoluSaatler.Add(saat);
            this.randevular.Add(yeniRandevu);
            
            MessageBox.Show($"{yeniRandevu.Ad} isimli hastaya {saat} saatine randevu alınmıştır");
            DialogResult cevap = MessageBox.Show($"Randevunuzu yazdırmak ister misiniz?\n", "Yazdır", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            butonlarıAktifYap();
            if (cevap == DialogResult.Yes)
            {
                
                printPreviewDialog1.ShowDialog();


            }

            FormuTemizle();
            gbSaatler.Visible = false;
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(doktorlar!=null)
            {
                cmbDoktor.Items.Clear();
                brabsaGoreDoktor(doktorlar, Convert.ToString(cmbBrans.SelectedItem));
            }
           
        }
        public void brabsaGoreDoktor(List<Doktorlar> hemsireler, string brans) 
        {
            List<Doktorlar> bransinDoktorlari = hemsireler.Where(x => Convert.ToString(x.Branslar1) == brans).ToList() ;
            cmbDoktor.Items.AddRange(bransinDoktorlari.ToArray());
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbSaatler.Visible = true;
            seciliDoktor = cmbDoktor.SelectedItem as Doktorlar;
            butonPasifYap(seciliDoktor.DoluSaatler);
        }

        private void txtHastaArama_TextChanged(object sender, EventArgs e)
        {
            List<Hastalar> aramaSonucu = MyTool<Hastalar>.Ara(hastalar, txtHastaArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
        private void ListeyiDoldur(List<Hastalar> aramaSonucu)
        {
            lstKisi.Items.Clear();
            foreach (Hastalar item in aramaSonucu)
            {
                lstKisi.Items.Add(item);
            }
        }
        Font fntDetay = new Font("Times New Roman", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString (DateTime.Now.ToShortDateString(), fntDetay, sb, 700, 100, fmt);
            Font print_font = new Font("Times New Roman", 14);
            e.Graphics.DrawString($"Saat:{saat} de {(cmbBrans.SelectedItem).ToString()} Kliniğinde Dr.{(cmbDoktor.SelectedItem).ToString()} ile randevunuz bulunmaktadır. ", print_font, Brushes.Black, 100, 175);

            e.Graphics.DrawString($"Randevu saatinizden 10 dakika önce kliniğinizde hazır bulunun.", print_font, Brushes.Black, 100, 200);

        }
    }
}
