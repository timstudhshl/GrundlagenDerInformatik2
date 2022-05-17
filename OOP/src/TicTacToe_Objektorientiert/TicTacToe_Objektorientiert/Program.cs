using System;

namespace TicTacToe_Objektorientiert
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ttt = new TicTacToe();
            ttt.StarteSpiel();

            Console.ReadLine();
        }
    }
}
