using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HastaneOtomasyon
{
  public  class Kisi
    {
        private string _ad, _soyad, _tckn;
        private DateTime _dogumTarihi;
        private Cinsiyetler _cinsiyet;


        public string Ad { get => _ad; set => _ad = AdSoyadHazirla (value); }
        public string Soyad { get => _soyad; set => _soyad = AdSoyadHazirla(value); }
        public string Tckn { get => _tckn; set => _tckn = TCKNKontrol(value); }
        public DateTime DogumTarihi { get => _dogumTarihi; set => _dogumTarihi = value; }
        public Cinsiyetler Cinsiyet { get => _cinsiyet; set => _cinsiyet = value; }

        private string TCKNKontrol(string tckn)
        {
            if (tckn.Length != 11)
                throw new Exception("TCKN 11 haneli olmalıdır");
            if (tckn[0] == '0')
                throw new Exception("TCKN '0' ile başlayamaz");
            foreach (char harf in tckn)
                if (!char.IsDigit(harf))
                    throw new Exception("TCKN içerisinde sadece rakam bulunmalıdır");
        
            return tckn;
        }
        private string AdSoyadHazirla(string kelime)
        {
            foreach (char harf in kelime)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception("Ad veya Soyad içerisinde geçersiz karakter bulunmaktadır.");
            }
            if (kelime.Trim().Length < 3)
                throw new Exception("Ad veya Soyad en az 3 karakter olmalı");

            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelime);
            return kelime;
        }

        public override string ToString()
        {
            return $"{Ad}: {Soyad}: {Tckn} : {DogumTarihi}: {Cinsiyet} ";
        }

    }
    public enum Cinsiyetler
    {
        Erkek,
        Kadın,
        Belirsiz

    }
    public enum Branslar
    {
        Ortodonti,
        Dahiliye,
        Kardiyoloji,
        Psikoloji,
        Gastroloji,
        Ortopedi,
        KBB,
        Cildiye,
        Cerrahi,
        SinirBilim
    }
    public enum Gorevler
    {
        Danışma,
        Maliye,
        Güvenlik,
        Temizlik,
        Yönetim,
        Hukuk,
        Dökümantasyon,
        Bilgiİşlem,
        Bakım
    }
}
