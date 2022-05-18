using System;

namespace Vererbung1805
{
    internal class Dozent : Person
    {
        public string Lehrgebiet { get; set; }

        public Dozent(string vorname, string nachname, string lehrgebiet) : base(vorname, nachname)
        {
            Lehrgebiet = lehrgebiet;
        }

        public override void Ausgeben()
        {
            Console.WriteLine($"{Vorname} {Nachname} - {Lehrgebiet}");
        }
    }
}
