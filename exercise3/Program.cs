using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            string förnamn = "";
            string efternamn = "";
            try{
                try{
            System.Console.Write("Skriv in ditt förnamn: ");
            förnamn = Console.ReadLine();
            System.Console.Write("Skriv in ditt efternamn: ");
            efternamn = Console.ReadLine();
            }
            catch{
                throw new Exception("Användaren matade in fel tecken");
            }

            Console.WriteLine("Hej " + förnamn + " " + efternamn);
            System.Console.WriteLine("Ha en fin dag!");
            }catch(Exception e){
                System.Console.WriteLine(e);
            }
        }
    }
}
