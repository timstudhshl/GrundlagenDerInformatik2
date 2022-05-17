using System;
using System.Collections.Generic;

namespace ProjektEuler
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    internal class Problem1
    {
        public static void Ausführen()
        {
            var nummern = NummernBis1000();
            var vielfaches = VielfacheVon3Und5(nummern);
            for (int i = 0; i < vielfaches.Count; i++)
            {
                // Console.WriteLine($"{i}");
            }
            var summe = SummeVonListe(vielfaches);
            Console.WriteLine($"\n\nDie Summer der Vielfachen beträgt: {summe}");
        }

        // Rechnet die Summe aller Zahlen einer Liste zusammen
        private static int SummeVonListe(List<int> nummern)
        {
            int summe = 0;

            foreach (int i in nummern)
            {
                summe += i;
            }

            return summe;
        }

        private static List<int> VielfacheVon3Und5(List<int> nummern)
        {
            List<int> liste = new List<int>();
            foreach (int i in nummern)
            {
                if (i % 3 == 0 || i % 5 == 0) // Wenn die Zahl mod 3 oder mod 5 ist wird sie der Liste hinzugefügt
                    liste.Add(i);
            }

            return liste;
        }

        // Liste füllen mit Zahlen bis 1.000
        private static List<int> NummernBis1000()
        {
            List<int> liste = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                liste.Add(i);
            }

            return liste;
        }
    }
}
