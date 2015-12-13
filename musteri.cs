using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    class musteri
    {
        public int ID { get ; set ;}
        public int ceptel { get; set; }
        public string tel { get; set; }
        public int postakodu { get; set; }
        public string  ad { get; set; }
        public string soyad { get; set; }
        public sehir sehir { get; set; }
        public byte cinsiyet { get; set; } // 0 erkek 1 kadın olacak 
        public DateTime dogum_tarihi { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }
        
    
    }
}
