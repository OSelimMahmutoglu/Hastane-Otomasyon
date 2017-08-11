using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneKutuphane
{
    public class Doktorlar : Kisi, IMaasAlabilir
    {


        public List<Hemsireler> DoktorunHemsiresi { get; set; } = new List<Hemsireler>();
        public List<string> DoluSaatler { get; set; } = new List<string>();
        private Branslar _branslar;
        private decimal _maas;
        public Branslar Branslar1
        {
            get
            {
                return _branslar;
            }

            set
            {
                _branslar = value;
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
                _maas = value;
            }
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
        public override string ToString()
        {
            return $"{Ad} {Soyad} ";
        }
    }
}
