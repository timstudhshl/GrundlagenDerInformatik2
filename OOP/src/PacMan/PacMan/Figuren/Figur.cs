using PacMan.Spielelemente;
using System;

namespace PacMan.Figuren
{
    internal class Figur : Spielelement
    {
        public virtual void Bewegen()
        {
            Console.WriteLine("Figur bewegt sich");
        }
    }
}
