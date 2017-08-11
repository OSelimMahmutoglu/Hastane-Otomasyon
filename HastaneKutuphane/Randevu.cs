using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneKutuphane
{
  public  class Randevu : Hastalar
    {
        public string DoktorAdi { get; set; }
        public string RandevuKlinigi { get; set; }
        public List<string> Randevular { get; set; }
        
    }
}
