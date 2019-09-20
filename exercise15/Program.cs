using System;

namespace exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en metod som tar in två string variabler, lägger samman dessa och returnerar som en sträng. 
            // (Tex. Strängarna ”Hej på dig!” och ” Hur mår du?” blir ”Hej på dig! Hur mår du?”.
            string textEtt = "";
            string textTvå = "";

            try{
                System.Console.WriteLine("Mata in en textsträng: ");
                textEtt = Console.ReadLine();
                System.Console.WriteLine("Mata in en textsträng till: ");
                textTvå = Console.ReadLine();
            }catch{
                throw new Exception("Felaktig inmatning");
            }


            Console.Clear();
                PrintTwoStrings(textEtt,textTvå);


        }

        static string PrintTwoStrings(string firstString, string secondString)
        {
            string bothStrings = firstString + " " + secondString;
            System.Console.WriteLine(bothStrings);

            return bothStrings ;
        }
    }
}
