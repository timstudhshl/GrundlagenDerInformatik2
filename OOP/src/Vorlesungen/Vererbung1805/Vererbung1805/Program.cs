using System;

namespace Vererbung1805
{
    internal class Program
    {
        private static void Main() // string[] args
        {
            var person = new Person("Fritz", "Karlicek")
            {
                Wohnadresse = new Adresse("Marker Allee 123", 21342, "Hamm")
            };
            person.Ausgeben();

            var student = new Student("Hans", "Wurst", 12345)
            {
                Wohnadresse = new Adresse("asfedf", 24234, "sdfsdgg")
            };
            student.Ausgeben();

            var dozent = new Dozent("Edeltraut", "Müller", "Elektrotechnik")
            {
                Wohnadresse = new Adresse("asdgsda", 123434, "sdgsdg")
            };
            dozent.Ausgeben();

            TueIrgendwas(person);
            TueIrgendwas(student);
            TueIrgendwas(dozent);

            var umwandlung = (Person)student;
            TueIrgendwas(umwandlung); // Überladung funktioniert nicht bei dynamik ! Double Dispatch Problem !

            Console.ReadLine();
        }

        public static void TueIrgendwas(Person p)
        {
            Console.WriteLine("Person");
        }

        public static void TueIrgendwas(Student s)
        {
            Console.WriteLine("Student");
        }

        public static void TueIrgendwas(Dozent d)
        {
            Console.WriteLine("Dozent");
        }
    }
}
