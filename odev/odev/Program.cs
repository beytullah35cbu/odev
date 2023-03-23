using System;
using System.Collections.Generic;

namespace ArabaProgrami
{
    class araba
    {
        public string marka;
        public short model;
        public string renk;
    }

    class Program
    {
        static List<araba> Arabalar = new List<araba>();

        static void Main(string[] args)
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Lütfen araba markasını girin:");
                string marka = Console.ReadLine();

                Console.WriteLine("Lütfen araba modelini girin:");
                short model = short.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen araba rengini girin:");
                string renk = Console.ReadLine();

                araba benimArabam = new araba();
                benimArabam.marka = marka;
                benimArabam.model = model;
                benimArabam.renk = renk;

                Arabalar.Add(benimArabam);

                Console.WriteLine("Araba kaydedildi.");

                Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                string cevap = Console.ReadLine();

                if (cevap.ToLower() == "h")
                {
                    devam = false;
                }
            }

            Console.WriteLine("Kaydedilen arabaların listesi:");

            foreach (araba a in Arabalar)
            {
                Console.WriteLine("Marka: " + a.marka);
                Console.WriteLine("Model: " + a.model);
                Console.WriteLine("Renk: " + a.renk);
                Console.WriteLine();
            }

            Console.ReadKey();
        }


    }
}
      