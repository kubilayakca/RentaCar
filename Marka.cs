using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Marka
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public List<Model> Modeller { get; set; }

        //public override string ToString()
        //{
        //    return ID + " "+ Ad;
        //}
        public Marka()
        {
            Modeller = new List<Model>();
        }
    }
}
