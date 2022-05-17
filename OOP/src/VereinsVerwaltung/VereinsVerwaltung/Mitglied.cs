using System;

namespace VereinsVerwaltung
{
    internal class Mitglied
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public GeschlechtEnum Geschlecht { get; set; }

        public Mitglied(string vorname, string nachname, GeschlechtEnum geschlecht)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geschlecht = geschlecht;
        }

        public void Ausgeben()
        {
            Console.WriteLine($"Vorname: {Vorname} | Nachname: {Nachname} | Geschlecht: {Geschlecht}");
        }
    }

    public enum GeschlechtEnum
    {
        männlich,
        weiblich,
        divers,
        keineAngabe
    }
}
