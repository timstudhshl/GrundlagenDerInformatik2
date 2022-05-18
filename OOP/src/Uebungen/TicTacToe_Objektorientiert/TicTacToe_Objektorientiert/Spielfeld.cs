using System;

namespace TicTacToe_Objektorientiert
{
    internal class Spielfeld
    {
        private char[,] _feld;

        public Spielfeld()
        {
            SpielfeldInitialisieren();
        }

        public void Setzen(int zeile, int spalte, char spielstein)
        {
            _feld[zeile, spalte] = spielstein;
        }

        public bool IstBelegt(int zeile, int spalte)
        {
            return _feld[zeile, spalte] != ' ';
        }

        public bool HatGewonnen(char spielstein)
        {
            for (int i = 0; i < 3; i++)
            {
                if (_feld[0, i] == spielstein && _feld[1, i] == spielstein && _feld[2, i] == spielstein) // Vertical
                    return true;

                if (_feld[i, 0] == spielstein && _feld[i, 1] == spielstein && _feld[i, 2] == spielstein) // Horizontal
                    return true;
            }

            if (_feld[0, 0] == spielstein && _feld[1, 1] == spielstein && _feld[2, 2] == spielstein) // Diagonal oben links => unten rechts
                return true;

            if (_feld[0, 2] == spielstein && _feld[1, 1] == spielstein && _feld[2, 0] == spielstein) // Diagonal oben rechts => unten links
                return true;

            return false;
        }

        public bool HatIrgendwerGewonnen()
        {
            return HatGewonnen('X') || HatGewonnen('O');
        }

        public bool IstEinFeldFrei()
        {
            for (int zeile = 0; zeile < 3; zeile++)
            {
                for (int spalte = 0; spalte < 3; spalte++)
                {
                    if (_feld[zeile, spalte] == ' ')
                        return true;
                }
            }

            return false;
        }

        public void Ausgeben()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   1  2  3");
            Console.ResetColor();
            for (int zeile = 0; zeile < 3; zeile++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{zeile + 1} ");
                Console.ResetColor();
                for (int spalte = 0; spalte < 3; spalte++)
                {
                    Console.Write($"[{_feld[zeile, spalte]}]");
                }
                Console.WriteLine();
            }
        }

        private void SpielfeldInitialisieren()
        {
            _feld = new char[3, 3];
            for (int zeile = 0; zeile < 3; zeile++)
            {
                for (int spalte = 0; spalte < 3; spalte++)
                {
                    _feld[zeile, spalte] = ' ';
                }
            }
        }
    }
}
