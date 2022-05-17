using System;

namespace Mitfahrzentrale
{
    internal class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public void Ausgeben()
        {
            Console.Write($"{Vorname} {Nachname}");
        }
    }
}
