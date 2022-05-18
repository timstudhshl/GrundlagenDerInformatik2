using System;

namespace Vererbung1805
{
    internal class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public Adresse Wohnadresse { get; set; }

        protected double Schuhgroesse;

        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public virtual void Ausgeben()
        {
            Console.WriteLine($"{Vorname} {Nachname}");
        }
    }
}
