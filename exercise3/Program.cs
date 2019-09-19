using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Skriv in ditt förnamn: ");
            string förnamn = Console.ReadLine();
            System.Console.Write("Skriv in ditt efternamn: ");
            string efternamn = Console.ReadLine();
            
            Console.WriteLine("Hej " + förnamn + " " + efternamn);
        }
    }
}
