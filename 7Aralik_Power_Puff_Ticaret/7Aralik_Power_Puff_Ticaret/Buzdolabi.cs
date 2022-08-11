using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Aralik_Power_Puff_Ticaret
{
    class Buzdolabi
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }
        public int icHacim { get; set; }

        public Buzdolabi() { }

        public Buzdolabi(string Marka, string Model, double Fiyat, int icHacim)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Fiyat = Fiyat;
            this.icHacim = icHacim;
        }


    }
}
