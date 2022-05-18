namespace Vererbung1805
{
    internal class Adresse
    {
        public string Strasse { get; set; }
        public int Plz { get; set; }
        public string Ort { get; set; }

        public Adresse(string strasse, int plz, string ort)
        {
            Strasse = strasse;
            Plz = plz;
            Ort = ort;
        }
    }
}
