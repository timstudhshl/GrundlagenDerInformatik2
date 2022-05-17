using System;

namespace TicTacToe_Objektorientiert
{
    internal class Spieler : ISpieler
    {
        public char Spielstein { get; set; }

        public Spieler(char spielstein)
        {
            Spielstein = spielstein;
        }

        public void Ziehe(Spielfeld feld)
        {
            if (!feld.IstEinFeldFrei())
                return;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Bitte gib die Nummer der Zeile ein: ");
                Console.ResetColor();
                int zeile = Convert.ToInt16(Console.ReadLine()) - 1;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Bitte gib die Nummer der Spalte ein: ");
                Console.ResetColor();
                int spalte = Convert.ToInt16(Console.ReadLine()) - 1;

                if (!feld.IstBelegt(zeile, spalte))
                {
                    feld.Setzen(zeile, spalte, Spielstein);
                    return;
                }
            }
        }
    }
}
