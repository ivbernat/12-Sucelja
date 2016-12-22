using System;

namespace Vsite.CSharp
{
    public class Osoba : IComparable<Osoba>
    {
        public Osoba(string ime, string prezime, DateTime datumRoðenja, string mjestoRoðenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRoðenja = datumRoðenja;
            MjestoRoðenja = mjestoRoðenja;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}, {3}", Ime, Prezime, DatumRoðenja.ToShortDateString(), MjestoRoðenja);
        }

        public int CompareTo(Osoba other)
        {
            int rezultat = Prezime.CompareTo(other.Prezime);
            if (rezultat != 0)
                return Ime.CompareTo(other.Ime);

            throw new NotImplementedException();
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRoðenja;
        public readonly string MjestoRoðenja;
    }
}
