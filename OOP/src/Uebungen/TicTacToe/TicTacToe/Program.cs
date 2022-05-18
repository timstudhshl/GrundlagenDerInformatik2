using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var feld = Basic.Zufallsfeld();
            Basic.Ausgeben(feld);
            Console.WriteLine($"Spieler X hat gewonnen? {Basic.Gewonnen(feld, 'X')}");
            Console.WriteLine($"Spieler O hat gewonnen? {Basic.Gewonnen(feld, 'O')}");
            Console.WriteLine($"Weitere Züge möglich? {Basic.MehrZuegeMoeglich(feld)}");
            if (Basic.MehrZuegeMoeglich(feld))
            {
                feld = Basic.SetzeSymbol(feld);
                Basic.Ausgeben(feld);
            }
        }
    }
}
