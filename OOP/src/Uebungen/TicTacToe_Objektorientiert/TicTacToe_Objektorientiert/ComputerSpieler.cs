using System;

namespace TicTacToe_Objektorientiert
{
    internal class ComputerSpieler : ISpieler
    {
        public char Spielstein { get; set; }

        public ComputerSpieler(char spielstein)
        {
            Spielstein = spielstein;
        }

        public void Ziehe(Spielfeld feld)
        {
            Random rnd = new Random();
            if (!feld.IstEinFeldFrei())
                return;

            while (true)
            {
                int zeile = rnd.Next(0, 3);
                int spalte = rnd.Next(0, 3);

                if (!feld.IstBelegt(zeile, spalte))
                {
                    feld.Setzen(zeile, spalte, Spielstein);
                    return;
                }
            }
        }
    }
}
