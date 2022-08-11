using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Aralik_Power_Puff_Ticaret
{
    class Camasir_Makinesi
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }
        public int YikamaKap{ get; set; }

        public Camasir_Makinesi() { }

        public Camasir_Makinesi (string Marka, string Model, double Fiyat, int YikamaKap)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Fiyat = Fiyat;
            this.YikamaKap = YikamaKap;
        }


    }
}
