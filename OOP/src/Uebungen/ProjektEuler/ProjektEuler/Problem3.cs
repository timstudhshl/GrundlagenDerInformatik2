using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEuler
{
    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?
    internal class Problem3
    {
        public static void Ausführen()
        {
            long nummer = 600851475143;
            var prim = GroesstePrim(nummer);
            Console.Write($"{nummer} =");
            for (int index = 0; index < prim.Count; index++)
            {
                Console.Write($" {prim[index]}");
                if (index != prim.Count - 1)
                    Console.Write($" *");
            }

            Console.WriteLine($"\nDadurch ist der größte Primfaktor: {prim[prim.Count - 1]}");
        }

        // Findet die kleinstmöglich Primzahl zum Teilen
        private static long KleinsterFaktor(long nummer)
        {
            double end = Math.Sqrt(nummer);
            for (long i = 2; i <= end; i++)
            {
                var mod = nummer % i;
                if (mod == 0)
                    return i;
            }

            return nummer;
        }

        // Solange die Primzahl kleiner als die eingegeben Nummer Teile durch die kleinstmögliche Primzahl
        private static List<long> GroesstePrim(long nummer)
        {
            List<long> nummern = new List<long>();
            while (true)
            {
                long prim = KleinsterFaktor(nummer);
                nummern.Add(prim);
                if (prim < nummer)
                    nummer /= prim;
                else
                    return nummern;
            }
        }
    }
}
