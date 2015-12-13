using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Model
    {
        public int ID { get; set; }
        public string Ad { get; set; }

        //public int MarkaID { get; set; }

        public Marka Marka { get; set; }
    }
}
