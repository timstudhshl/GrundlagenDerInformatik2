namespace Bruch
{
    internal class ArrayReihe
    {
        private Bruch[] _brueche;

        public ArrayReihe(int laenge)
        {
            _brueche = new Bruch[laenge];
            ArrayFuellen();
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

        private void ArrayFuellen()
        {
            for (int index = 0; index < _brueche.Length; index++)
            {
                if (index == 0)
                {
                    _brueche[index] = new Bruch(1, 1);
                }
                else
                {
                    int nenner = _brueche[index - 1].Nenner * 2;
                    _brueche[index] = new Bruch(1, nenner);
                }
            }
        }
    }
}
