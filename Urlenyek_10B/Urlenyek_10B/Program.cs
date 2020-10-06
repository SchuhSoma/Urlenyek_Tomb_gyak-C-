using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Urlenyek_10B
{
    class Program
    {
        static string[] UrlenyNevek = new string[7];
        static int[] UrlenyMagassag = new int[7];
        static void Main(string[] args)
        {
            Feladat1Feltoltes(); Console.WriteLine("\n-------------------------------------\n");
            Feladat2Kiiratas(); Console.WriteLine("\n-------------------------------------\n");
            Feladat3OsszegzesiTetelAtlag(); Console.WriteLine("\n-------------------------------------\n");
            Feladat4LegkisebbUrleny(); Console.WriteLine("\n-------------------------------------\n");
            Feladat5MaximumKialasztasiTetel(); Console.WriteLine("\n-------------------------------------\n");
            Feladat6Kereses(); Console.WriteLine("\n-------------------------------------\n");
            Feladat7Kivagas();
            Console.ReadKey();
        }

        private static void Feladat7Kivagas()
        {
            Console.Write("Kérem adja meg az űrlény nevét: ");
            string BekertNev = Console.ReadLine().ToLower().Replace(" ", "");
            Console.WriteLine("Az áalakított űrlény név : {0}", BekertNev);
        }

        private static void Feladat6Kereses()
        {
            Console.WriteLine("Feladat 6: Keresés");
            Console.Write("Kérem adja meg az űrlény nevét: ");
            string BekertNev = Console.ReadLine().ToLower();
            Console.WriteLine("A bekért név kisbetükben : {0} ", BekertNev);
            int Szamlalo = 0;
            while(Szamlalo<UrlenyNevek.Length && BekertNev!=UrlenyNevek[Szamlalo].ToLower())
            {
                Szamlalo++;
            }
            if(Szamlalo==UrlenyNevek.Length)
            {
                Console.WriteLine("Nincs ilyen nevü űrlény a vizsgáltak között");
            }
            else
            {
                Console.WriteLine("Van ilyen nevü űrlény, akinek a magassága: {0} cm", UrlenyMagassag[Szamlalo]);
            }
        }

        private static void Feladat5MaximumKialasztasiTetel()
        {
            Console.WriteLine("Feladat 5: A legmagasabb űrlény neve, magassága");
            int MaximumMagassag = int.MinValue;
            string MaximumNev = "cica";
            for (int i = 0; i < UrlenyMagassag.Length; i++)
            {
                if (MaximumMagassag<UrlenyMagassag[i])
                {
                    MaximumMagassag = UrlenyMagassag[i];
                    MaximumNev = UrlenyNevek[i];
                }
            }
            Console.WriteLine("A legnagyobb űrlény neve: {0} , magassága: {1} cm", MaximumNev, MaximumMagassag);
        }

        private static void Feladat4LegkisebbUrleny()
        {
            Console.WriteLine("Feladat 4: a legkisebb űrlény neve magassága");
            int MinimumMagassag = int.MaxValue;
            string MinimumNev = "cica";
            for (int i = 0; i < UrlenyMagassag.Length; i++)
            {
                if(UrlenyMagassag[i]<MinimumMagassag)
                { 
                    MinimumMagassag = UrlenyMagassag[i];
                    MinimumNev = UrlenyNevek[i];
                }
            }
            Console.WriteLine("A legkisebb űrlény neve: {0} , magassága: {1} cm", MinimumNev, MinimumMagassag);
        }

        private static void Feladat3OsszegzesiTetelAtlag()
        {
            Console.WriteLine("Feladat 3: határozza meg az ürlények össz magasságát és átlagos magasságát");
            double Osszeg=0;
            double Atlag=0;
            for(int i=0;i<UrlenyMagassag.Length;i++)
            {
                Osszeg += (double)UrlenyMagassag[i];
            }
            Atlag = Osszeg / UrlenyMagassag.Length;
            Console.WriteLine("Az ürléyek össz magassága: {0} cm",Osszeg);
            Console.WriteLine("Az űrlények átlag magassága: {0:0.00} cm", Atlag);
        }

        private static void Feladat2Kiiratas()
        {
            Console.WriteLine("Feladat 2: Kiiratása az ürlényeknk és magasságuknak");
            for(int i=0; i<UrlenyNevek.Length; i++)
            {
                Console.WriteLine("Nev: {0,-8}  Magassag: {1,-3} cm",UrlenyNevek[i],UrlenyMagassag[i]);
            }
        }

        private static void Feladat1Feltoltes()
        {
            Console.WriteLine("Feladat 1: adatok feltöltése");
            UrlenyMagassag = new int[7] {100,250,300,400,175,260,195 };
            UrlenyNevek = new string[7] {"Laci","Sarikov","Béla","Ted","Mari","Sztalin","ET" };
        }
    }
}
