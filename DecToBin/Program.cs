using System;

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrivi un numero");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2));
            Console.ReadLine();

        }
    }
}
