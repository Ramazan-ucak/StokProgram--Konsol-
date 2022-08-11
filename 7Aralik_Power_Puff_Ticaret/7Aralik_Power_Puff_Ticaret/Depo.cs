using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Aralik_Power_Puff_Ticaret
{
    class Depo
    {
        Camasir_Makinesi[] camasirmakineleri = new Camasir_Makinesi[0];
        Bulasik_Makinesi[] bulasikmakineleri = new Bulasik_Makinesi[0];
        Buzdolabi[] buzdolaplari = new Buzdolabi[0];

        public void Ekle(Camasir_Makinesi cm)
        {
            Camasir_Makinesi[] gecici = new Camasir_Makinesi[camasirmakineleri.Length + 1];
            Array.Copy(camasirmakineleri, gecici, camasirmakineleri.Length);
            gecici[gecici.Length - 1] = cm;
            camasirmakineleri = gecici;
        }
        public void Ekle(Bulasik_Makinesi bm)
        {
            Bulasik_Makinesi[] gecici = new Bulasik_Makinesi[bulasikmakineleri.Length + 1];
            Array.Copy(bulasikmakineleri, gecici, bulasikmakineleri.Length);
            gecici[gecici.Length - 1] = bm;
            bulasikmakineleri = gecici;
        }
        public void Ekle(Buzdolabi bd)
        {
            Buzdolabi[] gecici = new Buzdolabi[buzdolaplari.Length + 1];
            Array.Copy(buzdolaplari, gecici, buzdolaplari.Length);
            gecici[gecici.Length - 1] = bd;
            buzdolaplari = gecici;
        }
        public void Yazdir()
        {
            foreach  (Camasir_Makinesi item in camasirmakineleri)
            {
                Console.WriteLine($"Marka= {item.Marka} Model= {item.Model} Fiyat= {item.Fiyat} YıkamaKapasitesi= {item.YikamaKap}");
            }
            foreach (Bulasik_Makinesi item in bulasikmakineleri)
            {
                Console.WriteLine($"Marka= {item.Marka} Model= {item.Model} Fiyat= {item.Fiyat} Program Sayisi= {item.ProgramSay}");
            }
            foreach (Buzdolabi item in buzdolaplari)
            {
                Console.WriteLine($"Marka= {item.Marka} Model= {item.Model} Fiyat= {item.Fiyat} İcHacim= {item.icHacim}");
            }

        }
    }
}