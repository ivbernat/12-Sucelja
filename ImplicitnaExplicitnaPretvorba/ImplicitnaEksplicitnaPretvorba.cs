using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    public class ImplicitnaEksplicitnaPretvorba
    {
        static void Main(string[] args)
        {
            // TODO: Provjeriti koja sučelja implementira klasa System.Collections.Generic.Queue<T>
            Queue<string> red = new Queue<string>(new string[] { "Mirko", "Slavko", "Jure" });

            // TODO: Napisati naredbu koja će pomoću metode Queue<T>.Enqueue() dodati još jedan element u 'red' 
            red.Enqueue("Pero");
            // TODO: Proslijediti objekt 'red' metodi IspišiSveElemente():
            IspišiSveElemente(red);
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static void IspišiSveElemente<T>(IEnumerable<T> elementi)
        {
            // TODO: Napraviti eksplicitnu pretvorbu proslijeđenog argumenta u ICollection i ispisati broj elemenata.
            Console.WriteLine(((ICollection)elementi).Count);
            foreach (var e in elementi)
            {
                Console.WriteLine(e);
            }
        }
    }
}
