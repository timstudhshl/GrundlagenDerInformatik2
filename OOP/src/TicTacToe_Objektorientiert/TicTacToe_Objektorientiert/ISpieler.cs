using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Objektorientiert
{
    internal interface ISpieler
    {
        char Spielstein { get; set; }

        void Ziehe(Spielfeld feld);
    }
}
