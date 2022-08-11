using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Aralik_Power_Puff_Ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();

            #region Hazır ürünler

            Camasir_Makinesi cm1 = new Camasir_Makinesi("Regal", "c303", 5000, 6);
            d.Ekle(cm1);
            Bulasik_Makinesi bm1 = new Bulasik_Makinesi("Siemens", "x208", 6500, 5);
            d.Ekle(bm1);
            Buzdolabi bd1 = new Buzdolabi("Beko", "Ranga", 4590, 55);
            d.Ekle(bd1);



            #endregion

            bool devam = true;

            while (devam == true)
            {
                
                Console.WriteLine("***PowerPuffTicarete Hoşgeldiniz***");
                Console.WriteLine("1- Ürün Girişi");
                Console.WriteLine("2- Ürün Listele");
                Console.WriteLine("3- Çıkış");

                Console.WriteLine("Yapmak istediğiniz işlemi giriniz");
                string secenek = Console.ReadLine();

                switch (secenek)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1-Çamaşır Makinesi Girişi");
                        Console.WriteLine("2-Bulasık Makinesi Girişi");
                        Console.WriteLine("3-Buzdolabı Makinesi Girişi");

                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Camasir_Makinesi cm = new Camasir_Makinesi();
                            Console.WriteLine("Marka giriniz");
                            cm.Marka = Console.ReadLine();
                            Console.WriteLine("Model giriniz");
                            cm.Model = Console.ReadLine();
                            Console.WriteLine("Fiyat giriniz");
                            cm.Fiyat = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Yıkama kapasitesi giriniz");
                            cm.YikamaKap = Convert.ToInt32(Console.ReadLine());
                            d.Ekle(cm);
                        }
                        if (secim == 2)
                        {
                            Bulasik_Makinesi bm = new Bulasik_Makinesi();
                            Console.WriteLine("Marka giriniz");
                            bm.Marka = Console.ReadLine();
                            Console.WriteLine("Model giriniz");
                            bm.Model = Console.ReadLine();
                            Console.WriteLine("Fiyat giriniz");
                            bm.Fiyat = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Program Sayısı giriniz");
                            bm.ProgramSay = Convert.ToInt32(Console.ReadLine());
                            d.Ekle(bm);
                        }
                        if (secim == 3)
                        {
                            Buzdolabi bd = new Buzdolabi();
                            Console.WriteLine("Marka giriniz");
                            bd.Marka = Console.ReadLine();
                            Console.WriteLine("Model giriniz");
                            bd.Model = Console.ReadLine();
                            Console.WriteLine("Fiyat giriniz");
                            bd.Fiyat = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("içhacmini giriniz");
                            bd.icHacim = Convert.ToInt32(Console.ReadLine());
                            d.Ekle(bd);
                        }
                        break;

                    case "2":
                        Console.Clear();
                        d.Yazdir();

                        break;

                    case "3":
                        devam = false;
                        break; 
                }

                


            }


        }
    }
}
