using System;

namespace Bruch
{
    internal class Bruch : IComparable
    {
        // Klassenvariablen
        private int _zaehler;
        private int _nenner;

        // Getter und Setter
        public int GetZaehler()
        {
            return _zaehler;
        }
        public void SetZaehler(int zaehler)
        {
            _zaehler = zaehler;
        }

        public int GetNenner()
        {
            return _nenner;
        }
        public void SetNenner(int nenner)
        {
            if (nenner == 0) // Nenner darf nicht 0 sein, wenn doch wirf Fehlermeldung
            {
                throw new ArgumentException("Der Nenner darf nicht 0 sein!");
            }
            _nenner = nenner;
        }

        // Eigenschaftsmethoden
        public int Zaehler
        {
            get { return _zaehler; }
            set { _zaehler = value; }
        }
        public int Nenner
        {
            get { return _nenner; }
            set
            {
                if (value == 0) // Nenner darf nicht 0 sein, wenn doch wirf Fehlermeldung
                {
                    throw new ArgumentException("Der Nenner darf nicht 0 sein!");
                }
                _nenner = value;
            }
        }

        public double Dezimalzahl
        {
            get { return (double)Zaehler / Nenner; } // Konvertiert den Bruch in eine Dezimalzahl
        }

        public Bruch(int zaehler, int nenner) // Wird ausgeführt wenn man ein Objekt vom Typ Bruch erstellt
        {
            Zaehler = zaehler;
            Nenner = nenner;
        }

        public Bruch BildeKehrwert()
        {
            return new Bruch(Nenner, Zaehler); // Wechselt Zähler und Nenner und gibt ein neues Bruchobjekt zurück
        }

        public Bruch Multiplizieren(int zahl)
        {
            return new Bruch(Zaehler * zahl, Nenner);
        }
        public Bruch Multiplizieren(Bruch bruch)
        {
            return new Bruch(Zaehler * bruch.Zaehler, Nenner * bruch.Nenner);
        }

        public Bruch Dividieren(int zahl)
        {
            return new Bruch(Zaehler, Nenner * zahl);
        }
        public Bruch Dividieren(Bruch bruch)
        {
            var kehrwert = bruch.BildeKehrwert();
            var zaehler = Zaehler * kehrwert.Zaehler;
            var nenner = Nenner * kehrwert.Nenner;

            return new Bruch(zaehler, nenner);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) // Wenn angegebens Objekt gleich null ist kann man nicht weiter Prüfen
                return false;

            Bruch b = obj as Bruch; // Versucht das Objekt in ein Bruchobjekt zu konvertieren
            if (b == null) // Wenn konvertierung Fehlgeschlagen kann nicht weiter geprüft werden
                return false;

            // Gibt true zurück wenn Zähler und Nenner der Brüche übereinstimmen, passt es nicht wird false zurückgegeben
            return b.Zaehler == Zaehler && b.Nenner == Nenner; 
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return -1;

            Bruch b = obj as Bruch;
            if (b == null)
                throw new ArgumentException("Übergebenes Objekt ist kein Bruch!");

            if (b.Dezimalzahl > Dezimalzahl)
                return 1; // Übergebener Bruch ist größer
            else if (b.Dezimalzahl < Dezimalzahl)
                return -1; // Übergebener Bruch ist kleiner
            else
                return 0; // Beide Brüche sind gleich groß
        }

        public void Ausgeben()
        {
            Console.WriteLine($"{Zaehler}/{Nenner}");
        }
    }
}
