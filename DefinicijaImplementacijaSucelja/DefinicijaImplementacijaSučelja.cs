using System;

namespace Vsite.CSharp
{
    // definicija sučelja:
    public interface IMojeSučelje
    {
        // deklaracija (samo potpis) metode:
        void GenerirajMojDogađaj();
        // deklaracija svojstva:
        string Svojstvo { set; get; }
        // deklaracija dogadjaja:
        event MojDelegat MojDogađaj;
    }

    // deklaracija delegata
    public delegate void MojDelegat(object sender, EventArgs e);


    // TODO: Napišite kod klase Implementacija tako da implementira sučelje IMojeSučelje. 
    // TODO: Implementirajte metodu GenerirajMojDogađaj tako da ona generira događaj MojDogađaj
    // TODO: Implementirajte kod za Svojstvo
    public class Implementacija : IMojeSučelje

    {
        private string nešto;
        public string Svojstvo
        {
            get; set;
           
           
        }

        public event MojDelegat MojDogađaj;

        public void GenerirajMojDogađaj()
        {
            if (MojDogađaj != null)
                MojDogađaj(this, EventArgs.Empty);
                
        }
    }

    public class DefinicijaImplementacijaSučelja
    {
        // metode kao argument ne primaju konkretne tipove nego sučelja! 
        static void IspišiSvojstvo(IMojeSučelje ms)
        {
            ms.Svojstvo = "Dobar dan";
            Console.WriteLine(ms.Svojstvo);
        }

        static void DigniDogađaj(IMojeSučelje ms)
        {
            ms.MojDogađaj += ObradiDogađaj;
            ms.GenerirajMojDogađaj();
        }

        static void ObradiDogađaj(object sender, EventArgs args)
        {
            Console.WriteLine("Događaj obrađen!");
        }

        static void Main(string[] args)
        {
            // TODO: Inicijalizirajte objekt ms instancom objekta Implementacija i provjerite što će se ispisati izvođenjem koda
            IMojeSučelje ms = new Implementacija();

            IspišiSvojstvo(ms);
            DigniDogađaj(ms);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
