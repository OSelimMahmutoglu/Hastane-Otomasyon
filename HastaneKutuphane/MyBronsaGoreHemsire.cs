using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneKutuphane
{
   public static class MyBronsaGoreHemsire
    {
        public static List<Hemsireler> hemsireSecimi(List<Hemsireler> hemsireler, string brans) // statik bir hemsireler tanımladık. 
        {
            List<Hemsireler> bosHemsireler = hemsireler.Where(x => Convert.ToString(x.HBranslar) == brans).ToList(); 
            //hemşirelerin branşı  bransın içinde branş varsa bunları bul ve boshemsirelere ata.   
            return bosHemsireler;
        }

    }
}
