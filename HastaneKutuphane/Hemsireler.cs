using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneKutuphane
{
    public class Hemsireler : Kisi, IMaasAlabilir
    {
        private HBranslar _hBranslar;
        private decimal _maas;
        public bool bosMu { get; set; } = true;

        public HBranslar HBranslar
        {
            get { return  _hBranslar; }
            set { _hBranslar = value; }

        }


        public decimal Maas
        {
            get
            {
                return _maas;
            }

            set
            {
                _maas = value;
            }
        }

        
    }
    public enum HBranslar
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
}
