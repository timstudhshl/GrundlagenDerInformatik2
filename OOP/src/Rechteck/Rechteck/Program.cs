using System;

namespace Rechteck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck(5.5, 13.37);
            Rechteck r2 = new Rechteck(187, 187);

            Console.WriteLine($"R1:");
            Console.WriteLine($"Seite 1 = {r1.Seite1}");
            Console.WriteLine($"Seite 2 = {r1.Seite2}");
            Console.WriteLine($"Fläche = {r1.Flaeche}");
            Console.WriteLine($"Umfang = {r1.Umfang}");
            Console.WriteLine();
            Console.WriteLine($"R2:");
            Console.WriteLine($"Seite 1 = {r2.Seite1}");
            Console.WriteLine($"Seite 2 = {r2.Seite2}");
            Console.WriteLine($"Fläche = {r2.Flaeche}");
            Console.WriteLine($"Umfang = {r2.Umfang}");
            Console.WriteLine();
            Console.WriteLine($"Sind die Rechtecke gleich groß? {r1.Equals(r2)}");
            Console.WriteLine($"Ist R1 größer R2? {r1.CompareTo(r2)}");
            Console.WriteLine("-1 = R1 ist größer | 0 = Gleichgroß | 1 = R2 ist größer");
        }
    }
}
