using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class ulke
    {
        public int ID { get; set; }
        public string ad { get; set; }
        public List<sehir> sehirler { get; set; }

        public ulke() 
        {
            sehirler = new List<sehir>();
        }
    }
}
