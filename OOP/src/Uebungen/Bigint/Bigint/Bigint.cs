using System;
using System.Linq;

namespace Bigint
{
    internal class Bigint
    {
        private int[] _nummer = new int[0];

        public string Nummer
        {
            get
            {
                string num = "";
                foreach (int i in _nummer)
                    num += i.ToString();
                return num;
            }
            set
            {
                if (value.Any(x => !char.IsNumber(x)))
                    throw new ArgumentException("Eine Ganzzahl darf keine Zeichen oder Buchstaben enthalten!");

                foreach (char c in value)
                    _nummer = _nummer.Concat(new int[] { c - '0' }).ToArray();
            }
        }

        public Bigint(string nummer)
        {
            Nummer = nummer;
        }

        public Bigint Addieren(Bigint big)
        {
            string output = "";
            // Größere und kleinere Zahl herausfinden und diese Rückwärts in einem string speichern
            string groeßer = Laenge() <= big.Laenge() ? Umdrehen(big.Nummer) : Umdrehen(Nummer);
            string kleiner = Laenge() <= big.Laenge() ? Umdrehen(Nummer) : Umdrehen(big.Nummer);

            int index = 0;
            int rest = 0;
            while (index < groeßer.Length)
            {
                (int zusatz, int zahl) ergerbnis;
                if (index < kleiner.Length)
                {
                    // kleiner[index] - '0' => wird benötigt um aus der Zahl gespeichert in einem Array den eigentlichen Zahlenwert zu bekommen
                    // Siehe ASCII Tabelle: https://www.torsten-horn.de/techdocs/ascii.htm
                    ergerbnis = AdditionMitRest(10, kleiner[index] - '0', groeßer[index] - '0', rest);
                }
                else
                {
                    ergerbnis = AdditionMitRest(10, groeßer[index] - '0', rest);
                }

                rest = ergerbnis.zusatz;
                output += ergerbnis.zahl;

                index++;
            }

            if (rest != 0)
            {
                output += rest;
            }

            return new Bigint(Umdrehen(output));
        }

        public int Laenge()
        {
            return _nummer.Length;
        }

        private (int rest, int zahl) AdditionMitRest(int basis, params int[] zahlen)
        {
            // Nimmt eine Zahl als Basis entgegen und beliebig viele andere Ganzzahlen und addiert diese
            int summe = 0, rest = 0, zahl = 0;
            foreach (int z in zahlen)
            {
                summe += z;
            }

            // Summe der Addition ist größer als die Basis => Rest Summe / Basis und die eigentlich Zahl Summe % Basis
            if (summe >= basis)
            {
                rest = summe / basis;
                zahl = summe % basis;
            }
            else
            {
                rest = 0;
                zahl = summe;
            }

            return (rest, zahl);
        }

        private string Umdrehen(string s)
        {
            // Konvertiert string zu einem char Array um dieses Array Rückwärts als string zurück zu geben
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
