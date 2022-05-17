using System;

namespace VereinsVerwaltung
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Mitglied dieterN = new Mitglied("Dieter", "Nadel", GeschlechtEnum.männlich);
            Mitglied christinaE = new Mitglied("Christina", "Eichmann", GeschlechtEnum.weiblich);
            Mitglied katharinaN = new Mitglied("Katharina", "Nadel", GeschlechtEnum.weiblich);
            Mitglied mariaB = new Mitglied("Maria", "Baumgaertner", GeschlechtEnum.weiblich);
            Mitglied florianF = new Mitglied("Florian", "Freeh", GeschlechtEnum.divers);
            Mitglied florianB = new Mitglied("Florian", "Bachmeier", GeschlechtEnum.keineAngabe);

            MitgliederListe mitglieder = new MitgliederListe(dieterN, christinaE, katharinaN, mariaB, florianF, florianB);

            mitglieder.Ausgeben();
            Console.WriteLine();

            Console.WriteLine("Suche nach weiblichen Mitgliedern...");
            foreach (Mitglied mitglied in mitglieder.SucheNachGeschlecht(GeschlechtEnum.weiblich))
            {
                mitglied.Ausgeben();
            }
            Console.WriteLine();

            Console.WriteLine("Suche nach Mitgliedern, deren Vorname Florian ist...");
            foreach (Mitglied mitglied in mitglieder.SucheNachVorname("Florian"))
            {
                mitglied.Ausgeben();
            }
            Console.WriteLine();

            Console.WriteLine("Suche nach Mitgliedern, deren Nachname Nadel ist...");
            foreach (Mitglied mitglied in mitglieder.SucheNachNachname("Nadel"))
            {
                mitglied.Ausgeben();
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
