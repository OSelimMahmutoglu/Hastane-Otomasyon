using HastaneKutuphane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Personeller : Kisi, IMaasAlabilir
{
    private Gorevler _gorevler;
    private decimal _maas;

    public Gorevler Gorevler1
    {
        get
        {
            return _gorevler;
        }

        set
        {
            _gorevler = value;
        }
    }

    public decimal Maas
    {
        get
        {
            return _maas;
        }

        set
        {
            _maas= value;
        }
    }

    public enum Gorevler
    { 
        Danisma,
        Maliye,
        Güvenlik,
        Temizlik,
        Yonetim,
        Hukuk,
        Dokumantasyon,
        BilgiIslem,
        Bakim
    }
}

