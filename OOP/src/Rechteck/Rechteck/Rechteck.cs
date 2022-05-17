using System;

namespace Rechteck
{
    internal class Rechteck : IComparable
    {
        private double _seite1;
        private double _seite2;

        public Rechteck(double seite1, double seite2)
        {
            Seite1 = seite1;
            Seite2 = seite2;
        }

        // Getter und Setter
        public double GetSeite1()
        {
            return _seite1;
        }
        public void SetSeite1(double wert)
        {
            if (wert <= 0)
                throw new ArgumentException("Eine Seite des Rechteck kann nicht <= 0 sein!");
            _seite1 = wert;
        }
        public double GetSeite2()
        {
            return _seite2;
        }
        public void SetSeite2(double wert)
        {
            if (wert <= 0)
                throw new ArgumentException("Eine Seite des Rechteck kann nicht <= 0 sein!");
            _seite2 = wert;
        }

        // Eigenschaftsmethoden
        public double Seite1
        {
            get { return _seite1; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Eine Seite des Rechteck kann nicht <= 0 sein!");
                _seite1 = value;
            }
        }
        public double Seite2
        {
            get { return _seite2; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Eine Seite des Rechteck kann nicht <= 0 sein!");
                _seite2 = value;
            }
        }

        public double Flaeche
        {
            get { return Seite1 * Seite2; }
        }
        public double Umfang
        {
            get { return Seite1 * 2 + Seite2 * 2; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Rechteck r = obj as Rechteck;
            if (r == null)
                return false;

            return r.Seite1 == Seite1 && r.Seite2 == Seite2;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return -1;

            Rechteck r = obj as Rechteck;
            if (r == null)
                throw new ArgumentException("Übergebene Objekt ist kein Rechteck und kann somit nicht vergleichen werden");

            if (r.Flaeche > Flaeche)
                return 1;
            else if (r.Flaeche < Flaeche)
                return -1;
            else
                return 0;
        }
    }
}
