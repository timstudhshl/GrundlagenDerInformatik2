using System.Collections.Generic;

namespace Bruch
{
    internal class ListReihe
    {
        private List<Bruch> _brueche = new List<Bruch>();

        public ListReihe(int laenge)
        {
            ListeFuellen(laenge);
        }

        public double SummeDerReihe()
        {
            double summe = 0;
            foreach (Bruch bruch in _brueche)
            {
                summe += bruch.Dezimalzahl;
            }

            return summe;
        }

        private void ListeFuellen(int laenge)
        {
            for (int index = 0; index < laenge; index++)
            {
                if (index == 0)
                {
                    _brueche.Add(new Bruch(1, 1));
                }
                else
                {
                    int nenner = _brueche[index - 1].Nenner * 2;
                    _brueche.Add(new Bruch(1, nenner));
                }
            }
        }
    }
}
