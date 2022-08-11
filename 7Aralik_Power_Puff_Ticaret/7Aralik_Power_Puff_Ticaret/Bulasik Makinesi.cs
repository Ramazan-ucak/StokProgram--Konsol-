using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Aralik_Power_Puff_Ticaret
{
    class Bulasik_Makinesi
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }
        public int ProgramSay { get; set; }

        public Bulasik_Makinesi() { }

        public Bulasik_Makinesi(string Marka, string Model, double Fiyat, int ProgramSay)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Fiyat = Fiyat;
            this.ProgramSay = ProgramSay;
        }

    }
}
