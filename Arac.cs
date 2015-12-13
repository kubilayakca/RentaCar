using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    enum YakitTurleri {Dizel=1, Benzinli=2, LPG=3 }
    public class Arac
    {
        public int ID { get; set; }
        public string Plaka { get; set; }
        public Model Model { get; set; }
        public int ModelYili { get; set; }
        public int Kilometre { get; set; }
        public string Renk { get; set; }
        public int Fiyat { get; set; }
        public DateTime SigortaTarihi { get; set; }
        public int Vites { get; set; } //1 Otomatik, 2 Manuel
        public int YakitTuru { get; set; } // 1 Dizel, 2 Benzinli, 3 LPG

    }
}
