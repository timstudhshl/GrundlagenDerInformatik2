using System;

namespace Bigint
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Bigint int1 = new Bigint("1000000000000000000000000000000");
            Bigint int2 = new Bigint("2000000000000000000000000000000");

            Console.WriteLine($"Int1: {int1.Nummer}");
            Console.WriteLine($"Int2: {int2.Nummer}");
            Console.WriteLine();

            Bigint int3 = int1.Addieren(int2);
            Console.WriteLine($"Int3 = Int1 + Int2 = {int3.Nummer}");

            Console.ReadLine();
        }
    }
}
