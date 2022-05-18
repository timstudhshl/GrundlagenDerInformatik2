using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjektEuler
{
    // A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.
    internal class Problem4
    {
        public static void Ausführen()
        {
            var palindrome = AllePalindrome();
            foreach (int palindrom in palindrome)
            {
                Console.WriteLine(palindrom);
            }

            var groesste = GroesstesPalindrom(palindrome);
            Console.WriteLine($"Somit ist das größte Palindrom: {groesste}");
        }

        private static int GroesstesPalindrom(List<int> palindrome)
        {
            int groesstes_palindrom = -1;

            foreach (int palindrom in palindrome)
            {
                // Wenn das aktuell größte Palindrom kleiner ist als das Element der Liste wird das aktuell größte mit dem Element der Liste überschrieben
                groesstes_palindrom = groesstes_palindrom < palindrom ? palindrom : groesstes_palindrom;
            }

            return groesstes_palindrom;
        }

        private static List<int> AllePalindrome()
        {
            List<int> palindrome = new List<int>();

            for (int zahl1 = 100; zahl1 < 1000; zahl1++)
            {
                for (int zahl2 = 100; zahl2 < 1000; zahl2++)
                {
                    int produkt = zahl1 * zahl2;
                    string produktString = produkt.ToString();
                    if (produktString.SequenceEqual(produktString.Reverse())) // Prüft ob der String gleich ist mit dem String rückwerts
                        palindrome.Add(produkt);
                }
            }

            return palindrome;
        }
    }
}