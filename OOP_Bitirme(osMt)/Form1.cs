using HastaneKutuphane;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP_Bitirme_osMt_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Context context = new Context();
        
        PersonelForm personelForm;
        HemsireForm hemsireForm;
        DoktorForm doktorForm;
        HastaForm hastaForm;
        RandevuForm randevuForm;

        private void HemsireToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (hemsireForm == null || hemsireForm.IsDisposed)
            {
                hemsireForm = new HemsireForm();
                hemsireForm.MdiParent = this;
                hemsireForm.hemsireler = context.Hemsireler;
                hemsireForm.Show();
            }
        }
        public void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hastaForm == null || hastaForm.IsDisposed)
            {
                hastaForm = new HastaForm();
                hastaForm.MdiParent = this;
                hastaForm.hastalar = context.Hastalar;
                hastaForm.Show();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (personelForm == null || personelForm.IsDisposed)
            {
                personelForm = new PersonelForm();
                personelForm.MdiParent = this;
                personelForm.Personeller = context.Personeller;
                personelForm.Show();
            }
        }

        private void DoktorIsleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (doktorForm == null || doktorForm.IsDisposed)
            {
                doktorForm = new DoktorForm();
                doktorForm.MdiParent = this;
                doktorForm.Doktorlar = context.Doktorlar;
                doktorForm.Hemsireler = context.Hemsireler;
                doktorForm.Show();
            }
        }
        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (randevuForm == null || randevuForm.IsDisposed)
            {
                randevuForm = new RandevuForm();
                randevuForm.MdiParent = this;
                randevuForm.randevular = context.Randevular;
                randevuForm.hastalar = context.Hastalar;
                randevuForm.Show();
            }
        }

        private void dışarAktarToolStripMenuItem_Click(object sender, EventArgs e) // Dışarı aktarı context i dışarı atarak yaptık, çünkü tüm class lar context class ının içinde var. 
        {
            if (context == null)
            {
                MessageBox.Show("zaten kimse kayıtlı değil neyi dışarı aktaracaksın");
                return;
            }
            DosyaKaydet.Title = "Bir jhon dosyası kaydedin";
            DosyaKaydet.Filter = "(*.json)|*.json";
            DosyaKaydet.FileName = string.Empty;
            DosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (DosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(DosyaKaydet.FileName, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(dosya);
                writer.Write(JsonConvert.SerializeObject(context));
                writer.Close();
                writer.Dispose();
                MessageBox.Show($"{context.Hastalar.Count} adet kisi json olarak kaydedildi");
            }
        }


        private void içeAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaAc.Title = "Bir Kisi json dosyasını seçiniz";
            DosyaAc.Filter = "(*Json|*.json";
            DosyaAc.FileName = string.Empty;
            DosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DosyaAc.Multiselect = false;

            if (DosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.OpenRead(DosyaAc.FileName);
                StreamReader reader = new StreamReader(dosya);
                string dosyaIcerigi = reader.ReadToEnd();

                try
                {
                    context = JsonConvert.DeserializeObject<Context>(dosyaIcerigi); // context in tipi Context class. O halde içeriye çektğin şey de Context tpinde olacak. Burada list falan tanımlamana gerek yok. 
                }
                catch (Exception)
                {
                    MessageBox.Show("Aktarım yapılamadı.");

                }
                //ListeyiDoldur(); // direkt context in içine dosya içeriğini atarak olayı çözdük, listeyi doldura vs ihtiyacımız olmadı. Üstteki context satırı zaten işi çözüyor. 
                dosya.Close();
                reader.Close();
                reader.Dispose();
                MessageBox.Show($" Kayıtlar programa aktarıldı");
            }
        }

        private void dosyaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
