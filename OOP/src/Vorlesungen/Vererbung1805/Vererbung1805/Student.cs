using System;

namespace Vererbung1805
{
    internal class Student : Person
    {
        public long Matrikelnummer { get; set; }

        public Student(string vorname, string nachname, long matrikelnummer) : base(vorname, nachname)
        {
            Matrikelnummer = matrikelnummer;

            Schuhgroesse = 12;
        }

        public override void Ausgeben()
        {
            Console.WriteLine($"{Vorname} {Nachname} - {Matrikelnummer}");
        }
    }
}
