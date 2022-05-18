using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Basic
    {
        public static char[,] Zufallsfeld()
        {
            char[,] feld = new char[3, 3];
            Random rnd = new Random();

            for (int y = 0; y < 3; y++) // Zeile
            {
                for (int x = 0; x < 3; x++) // Spalte
                {
                    switch (rnd.Next(0, 3)) // Zufallszahl zwischen 0 bis einschließlich 2
                    {
                        case 1:
                            feld[x, y] = 'X';
                            break; // Ohne break würde er die anderen Fälle auch abarbeiten
                        case 2:
                            feld[x, y] = 'O';
                            break;
                        default:
                            feld[x, y] = ' ';
                            break;
                    }
                }
            }

            return feld;
        }

        public static bool Gewonnen(char[,] feld, char symbol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (feld[0, i] == symbol && feld[1, i] == symbol && feld[2, i] == symbol) // Horizontal
                    return true;
                if (feld[i, 0] == symbol && feld[i, 1] == symbol && feld[i, 2] == symbol) // Vertikal
                    return true;
            }

            if (feld[0, 0] == symbol && feld[1, 1] == symbol && feld[2, 2] == symbol) // Oben links => unten rechts
                return true;

            if (feld[0, 2] == symbol && feld[1, 1] == symbol && feld[2, 0] == symbol) // Unten links => oben rechts
                return true;

            return false;
        }

        public static bool MehrZuegeMoeglich(char[,] feld)
        {
            if (Gewonnen(feld, 'X') || Gewonnen(feld, 'O')) // Wenn schon jemand Gewonnen hat sind keine Züge mehr "möglich"
                return false;

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (feld[x, y] == ' ') // Wenn ein Feld noch keinen Wert hat kann man noch weitere Züge tätigen
                        return true;
                }
            }

            return false;
        }

        public static char[,] SetzeSymbol(char[,] feld)
        {
            var falsche_eingabe = true;
            do
            {
                Console.Write("Gib die Spalte an: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Gib die Zeile an: ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (feld[x - 1, y - 1] != ' ')
                    falsche_eingabe = true;
                else
                {
                    feld[x - 1, y - 1] = 'X';
                    falsche_eingabe = false;
                }
            } while (falsche_eingabe);

            return feld;
        }

        public static void Ausgeben(char[,] feld)
        {
            Console.WriteLine("   1  2  3");
            for (int y = 0; y < 3; y++)
            {
                Console.Write($"{y + 1} ");
                for (int x = 0; x < 3; x++)
                {
                    Console.Write($"[{feld[x, y]}]");
                }
                Console.Write("\n");
            }
        }
    }
}
