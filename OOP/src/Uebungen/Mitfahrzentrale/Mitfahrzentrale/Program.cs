using System;
using System.Collections.Generic;

namespace Mitfahrzentrale
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<Person> personen = new List<Person>()
            {
                new Person("Jörg", "Meister"),
                new Person("Kristian", "Meyer"),
                new Person("Marko", "Sankt"),
                new Person("Andreas", "Schulz"),
                new Person("Philipp", "Kalb"),
                new Person("Kerstin", "Drescher"),
                new Person("Franziska", "Luft"),
                new Person("Ute", "Meister"),
                new Person("Max", "Peters"),
                new Person("Marcel", "Gerste"),
                new Person("Felix", "Kruger"),
                new Person("Anke", "Meier"),
                new Person("Erik", "Dresdner")
            };

            Fahrt fahrt1 = new Fahrt("Berlin", "München", personen[0]);
            fahrt1.MitfahrerHinzufuegen(personen[1], personen[8], personen[7]);
            fahrt1.Ausgeben();
            Console.WriteLine();

            Fahrt fahrt2 = new Fahrt("Hamburg", "Bremen", personen[5]);
            fahrt2.MitfahrerHinzufuegen(personen[7], personen[3], personen[10]);
            fahrt2.Ausgeben();
            Console.WriteLine();

            Fahrt fahrt3 = new Fahrt("Hamburg", "Bremen", personen[12]);
            fahrt3.MitfahrerHinzufuegen(personen[2], personen[4], personen[6], personen[9]); // Wird einen Fehler werfen
            fahrt3.Ausgeben();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
