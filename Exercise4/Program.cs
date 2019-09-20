using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hej vad heter du?");
            string namn = Console.ReadLine();
            PrintText(namn);
        }
        static string PrintText  (string namn)
        {
                System.Console.WriteLine("Hello " + namn);
            return namn;
        }
    }
}
