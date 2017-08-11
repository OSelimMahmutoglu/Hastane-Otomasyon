using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneKutuphane
{
   public class Context
    {
        public List<Personeller> Personeller { get; set; } = new List<Personeller>();
        public List<Hastalar> Hastalar { get; set; } = new List<Hastalar>();
        public List<Doktorlar> Doktorlar { get; set; } = new List<Doktorlar>();
        public List<Hemsireler> Hemsireler { get; set; } = new List<Hemsireler>();

        public List<Hemsireler> BosHemsireler { get; set; } = new List<Hemsireler>();

        public List<Randevu> Randevular { get; set; } = new List<Randevu>();
    }
}
