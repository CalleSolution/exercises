using System;

namespace exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa metoden Addera() som tar in två heltal och returnerar summan.

            int firstNumb = 0;
            int secondNumb = 0;

            try{
                Console.Write("Mata in ett tal: ");
                firstNumb = int.Parse(Console.ReadLine());

                Console.Write("Mata in ett tal till: ");
                secondNumb = int.Parse(Console.ReadLine());
            }catch{
                throw new Exception("Användaren matade in fel tecken");

            }
            PrintTotal(firstNumb,secondNumb);
        }

        public static int PrintTotal (int firstNumb, int secondNumb)
        {
            int sum = firstNumb + secondNumb;
            System.Console.WriteLine("Totalen blev: " + sum);

            return sum;
        }
    }
}
