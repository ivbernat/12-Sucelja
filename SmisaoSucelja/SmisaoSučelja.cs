using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    public class SmisaoSučelja
    {
        class UsporedbaPoImenu : IComparer<Osoba>
        {
            public int Compare(Osoba x, Osoba y)
            {
                return x.Ime.CompareTo(y.Ime);
            }
        }
        static void Ispiši(List<Osoba> list)
        {
            foreach (Osoba o in list)
                Console.WriteLine(o);
        }

        public static void SortiranoPoNečemu(List<Osoba> osobe)
        {
            UsporedbaPoImenu upi = new UsporedbaPoImenu();
            osobe.Sort(upi);
        }

        public static void SortiranoPoImenu(List<Osoba> osobe)
        {
            // TODO: Koristeæi preoptereæenu inaèicu metode List<T>.Sort(IComparer(T)) abecedno sortirati osobe prema njihovim imenima.
            osobe.Sort();
        }

        public static void SortiranoPoDatumuRođenja(List<Osoba> osobe)
        {
            // TODO: Koristeæi preoptereæenu inaèicu metode List<T>.Sort(Comparison(T)) sortirati osobe prema njihovim datumima roðenja.
            osobe.Sort((x, y) => x.DatumRoðenja.CompareTo(y.DatumRoðenja));
            
        }

        public static void SortiranoPoMjestuRođenja(List<Osoba> osobe)
        {
            // TODO: Koristeæi preoptereæenu inaèicu metode List<T>.Sort(Comparison(T)) osobe sortirati prema njihovim mjestima roðenja.
            osobe.Sort((x, y) => x.MjestoRoðenja.CompareTo(y.MjestoRoðenja));
        }

        static void Main(string[] args)
        {
            List<Osoba> popisOsoba = new List<Osoba>();

            popisOsoba.Add(new Osoba("Ana", "Mariæ", new DateTime(1975, 7, 12), "Split"));
            popisOsoba.Add(new Osoba("Žarko", "Leviæ", new DateTime(1965, 12, 4), "Osijek"));
            popisOsoba.Add(new Osoba("Marko", "Karamatiæ", new DateTime(1983, 4, 2), "Sinj"));
            popisOsoba.Add(new Osoba("Tomislav", "Kralj", new DateTime(1971, 11, 5), "Beli Manastir"));

            Console.WriteLine("Ispis prije sortiranja:");
            Ispiši(popisOsoba);
            Console.WriteLine();

            try
            {
                Console.WriteLine("Sortiramo podrazumijevano:");
                SortiranoPoNečemu(popisOsoba);
                Ispiši(popisOsoba);
                Console.WriteLine();

                Console.WriteLine("Sortiramo po imenu:");
                SortiranoPoImenu(popisOsoba);
                Ispiši(popisOsoba);
                Console.WriteLine();

                Console.WriteLine("Sortiramo po datumu roðenja:");
                SortiranoPoDatumuRođenja(popisOsoba);
                Ispiši(popisOsoba);

                Console.WriteLine("Sortiramo po mjestu roðenja:");
                SortiranoPoMjestuRođenja(popisOsoba);
                Ispiši(popisOsoba);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
