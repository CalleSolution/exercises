using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
    //         # If-satsen
    //         ## Övning 6

    // Kontrollera värdet (del 1)
	// Skapa ett program som ställer frågan ”Är det fint väder?”. 
    // Om användaren svara ”j” skriver programmet ut ”Vi går på picknick!”. 
    // Annars händer ingenting.


            //Skapar fråga "Är det fint väder?"
            System.Console.WriteLine("Är det fint väder?");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            
            //villkorssats OM j skriv ut " vi går på picknick, ANNARS ingenting

            if (answer == "j")
            {
                System.Console.WriteLine("Vi går ut på picknick!");
            }
            else
            {

            }
        }
    }
}
