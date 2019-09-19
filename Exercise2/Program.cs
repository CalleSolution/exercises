using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Mata in ett tal:");
            int tal1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Mata in ett tal:");
            int tal2 = int.Parse(Console.ReadLine());

            int sum = tal1 + tal2;
            
            Console.WriteLine("Summan av talet blir: " + sum);
        }
    }
}
