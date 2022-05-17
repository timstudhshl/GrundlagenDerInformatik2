using System;

namespace Bruch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region --- Rechnen mit Brüchen ---

            //Bruch b1 = new Bruch(1, 5); // Erzeuge neues Bruchobjekt
            //Bruch b2 = new Bruch(4, 5);

            //Console.Write("Bruch B1: ");
            //b1.Ausgeben();
            //Console.Write("Bruch B2: ");
            //b2.Ausgeben();

            //Console.Write("Kehrwert von Bruch B1: ");
            //b1.BildeKehrwert().Ausgeben();

            //Console.Write("B1 * 5 = ");
            //b1.Multiplizieren(5).Ausgeben();
            //Console.Write("B1 * B2 = ");
            //b1.Multiplizieren(b2).Ausgeben();

            //Console.Write("B1 / 5 = ");
            //b1.Dividieren(5).Ausgeben();
            //Console.Write("B1 / B2 = ");
            //b1.Dividieren(b2).Ausgeben();

            //Console.WriteLine($"Ist der Bruch B1 gleich mit B2? {b1.Equals(b2)}");
            //Console.WriteLine($"Ist der Bruch B1 größer als B2? {b1.CompareTo(b2)}");
            //Console.WriteLine("1 = B1 < B2 | 0 = B1 = B2 | -1 = B1 > B2");

            //var falsche_eingabe = true;
            //do
            //{
            //    try // Versuche nachfolgenden Code auszuführen
            //    {
            //        Console.Write("Gib einen Zähler ein: ");
            //        int zaehler = Convert.ToInt32(Console.ReadLine()); // Einlesen der Eingabe und Konvertierung zu einer Ganzzahl
            //        Console.Write("Gib einen Nenner ein: ");
            //        int nenner = Convert.ToInt32(Console.ReadLine());
            //        Bruch b = new Bruch(zaehler, nenner);
            //        falsche_eingabe = false;
            //        b.Ausgeben();
            //    } catch (Exception ex) // Wenn ein Fehler entstanden ist wird nachfolgender Code ausgeführt
            //    {
            //        Console.WriteLine(ex.Message);
            //        falsche_eingabe = true;
            //    }
            //} while (falsche_eingabe); // Solange eine fehlerhafte Eingabe getätigt wurde wiederhole die Eingabe

            #endregion --- Rechnen mit Brüchen ---

            #region --- Reihe mit Array ---

            // ArrayReihe areihe = new ArrayReihe(20);
            // Console.WriteLine($"Summe der Reihe: {areihe.SummeDerReihe()}");

            #endregion --- Reihe mit Array ---

            #region --- Reihe mit Liste ---

            // ListReihe lreihe = new ListReihe(20);
            // Console.WriteLine($"Summe der Reihe: {lreihe.SummeDerReihe()}");

            #endregion --- Reihe mit Liste ---

            #region --- Geometrische Reihe ---

            GeometrischeReihe geo = new GeometrischeReihe(10);
            Console.WriteLine($"Summe der Reihe: {geo.Summe}");
            Console.WriteLine();
            foreach (Bruch b in geo.BruecheMitGroeßeremNenner(6))
            {
                b.Ausgeben();
            }

            #endregion --- Geometrische Reihe ---

            Console.ReadLine();
        }
    }
}
