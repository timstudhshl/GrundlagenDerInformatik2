using System;

namespace TicTacToe_Objektorientiert
{
    internal class TicTacToe
    {
        private Spielfeld _feld;
        private ISpieler _spieler1;
        private ISpieler _spieler2;
        private ISpieler _aktueller_spieler;

        public void StarteSpiel(bool computer = false)
        {
            _feld = new Spielfeld();
            if (computer)
            {
                _spieler1 = new ComputerSpieler('X');
                _spieler2 = new ComputerSpieler('O');
            }
            else
            {
                _spieler1 = new Spieler('X');
                _spieler2 = new Spieler('O');
            }

            _feld.Ausgeben();
            do
            {
                WechselSpieler();
                Console.WriteLine($"Spieler {_aktueller_spieler.Spielstein} ist an der Reihe:");
                _aktueller_spieler.Ziehe(_feld);
                if (!computer)
                    Console.Clear();
                _feld.Ausgeben();

                if (_feld.HatGewonnen(_aktueller_spieler.Spielstein))
                {
                    Console.WriteLine("Spieler " + _aktueller_spieler.Spielstein + " hat gewonnen!");
                    break;
                }
            } while (_feld.IstEinFeldFrei());

            if (!_feld.HatIrgendwerGewonnen() && !_feld.IstEinFeldFrei())
                Console.WriteLine("Unentschieden!");
        }

        private void WechselSpieler()
        {
            if (_aktueller_spieler == _spieler1)
            {
                _aktueller_spieler = _spieler2;
            }
            else
            {
                _aktueller_spieler = _spieler1;
            }
        }
    }
}
