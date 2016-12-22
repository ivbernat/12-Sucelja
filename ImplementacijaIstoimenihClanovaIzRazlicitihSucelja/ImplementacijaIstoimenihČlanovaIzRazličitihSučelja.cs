using System;

namespace Vsite.CSharp
{
    public class ImplementacijaIstoimenihČlanovaIzRazličitihSučelja
    {
        public interface ISkokUvis
        {
            void Skoči();
        }

        public interface ISkokUdalj
        {
            void Skoči();
        }

        // TODO: U implementaciju metode Skoči u klasi Desetobojac napisati naredbu koja će ispisati "Hop". U metodi Main pozvati tu metodu, pokrenuti program i provjeriti ispis.

        // TODO: Definirati da klasa Desetobojac implementira sučelje ISkokUvis. U implementaciji metode tog sučelja treba ispisati "Hop u vis".
        // TODO: U metodi Main dodati naredbu koja će pozvati metodu Skoči iz sučelja ISkokUVis. Pokrenuti program i provjeriti ispise.

        // TODO: Definirati da klasa Desetobojac implementira sučelje ISkokUDalj.U implementaciji metode tog sučelja treba ispisati "Hop u dalj".
        // TODO: U metodi Main dodati naredbu koja će pozvati metodu Skoči iz sučelja ISkokUDalj. Pokrenuti program i provjeriti ispise.
        public class Desetobojac :  ISkokUvis, ISkokUdalj
        {
             void ISkokUdalj.Skoči()
            {
                Console.WriteLine("Hop u dalj");
            }
            public void Skoči()
             {
                 Console.WriteLine("Hop");
             }
            void ISkokUvis.Skoči()
            {
                Console.WriteLine("Hop u vis");
            }
        }

        static void Main(string[] args)
        {
            Desetobojac db = new Desetobojac();
            db.Skoči();
            ((ISkokUvis)db).Skoči();
            ((ISkokUdalj)db).Skoči();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
