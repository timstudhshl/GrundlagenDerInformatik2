using System;
using System.Collections.Generic;

namespace Mitfahrzentrale
{
    internal class Fahrt
    {
        public string Startort { get; set; }
        public string Zielort { get; set; }

        public Person Fahrer { get; private set; }

        public List<Person> Mitfahrer { get; set; }

        public Fahrt(string startort, string zielort, Person fahrer)
        {
            Startort = startort;
            Zielort = zielort;
            Fahrer = fahrer;
            Mitfahrer = new List<Person>();
        }

        public void MitfahrerHinzufuegen(params Person[] personen)
        {
            foreach (Person person in personen)
            {
                if (personen != null && Mitfahrer.Count < 3)
                {
                    Mitfahrer.Add(person);
                }
                else
                {
                    throw new Exception("Die fahrt ist schon voll. Es sind bereits 3 Mitfahrer der Fahrt zugeordnet!");
                }
            }
        }

        public void Ausgeben()
        {
            Console.WriteLine($"Startort: {Startort} | Zielort: {Zielort}");
            Console.Write("Fahrer: ");
            Fahrer.Ausgeben();
            Console.WriteLine("\nMitfahrer:");
            foreach (Person person in Mitfahrer)
            {
                person.Ausgeben();
                Console.WriteLine();
            }
        }
    }
}
