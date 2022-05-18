using System;

namespace PacMan
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Spielfeld spielfeld = new Spielfeld();

            spielfeld.PacMan.Bewegen();
            spielfeld.Geister[0].Bewegen();

            Console.ReadLine();
        }
    }
}
