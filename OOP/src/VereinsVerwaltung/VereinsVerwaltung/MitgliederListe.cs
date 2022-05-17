using System;
using System.Collections.Generic;

namespace VereinsVerwaltung
{
    internal class MitgliederListe
    {
        List<Mitglied> _mitglieder = new List<Mitglied>();

        public MitgliederListe(params Mitglied[] mitglieder)
        {
            foreach (Mitglied mitglied in mitglieder)
            {
                Hinzufuegen(mitglied);
            }
        }

        public void Hinzufuegen(Mitglied mitglied)
        {
            _mitglieder.Add(mitglied);
        }

        public IEnumerable<Mitglied> SucheNachVorname(string vorname)
        {
            return _mitglieder.FindAll(mitglied => mitglied.Vorname == vorname);
        }

        public IEnumerable<Mitglied> SucheNachNachname(string nachname)
        {
            return _mitglieder.FindAll(mitglied => mitglied.Nachname == nachname);
        }

        public IEnumerable<Mitglied> SucheNachGeschlecht(GeschlechtEnum geschlecht)
        {
            return _mitglieder.FindAll(mitglied => mitglied.Geschlecht == geschlecht);
        }

        public IEnumerable<Mitglied> Mitglieder()
        {
            return _mitglieder;
        }

        public void Ausgeben()
        {
            foreach (Mitglied mitglied in _mitglieder)
            {
                mitglied.Ausgeben();
            }
        }
    }
}
