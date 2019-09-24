using System;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            // # If-satsen
            // ## Övning 6

            // Kontrollera värdet (del 1)
            // Skapa ett program som ställer frågan ”Är det fint väder?”.
            // Om användaren svara ”j” skriver programmet ut ”Vi går på picknick!”. Annars händer ingenting.

            // Kontrollera värdet (del 2)
            // Arbeta vidare på övningen ovanför men lägg till att användaren kan svara ”n”. 
            // Då skriver programmet ut ”Vi stannar inne och läser en bok”. 
            // Det ska inte spela någon roll om användaren matar in stor eller liten bokstav.

//---------------------------------------------------------------------------------------------------------------------------
                         
            //Skapar fråga "Är det fint väder?" och läser strängen med deklarerad variabel answer.
            System.Console.WriteLine("Är det fint väder?");
            string answer = Console.ReadLine();

            //metoden ToLower(); omvandlar till liten bokstav.
            answer = answer.ToLower();
            
            //villkorssats OM j skriv ut " vi går på picknick, ANNARS OM "Vi stannar inne och läser en bok istället."

            if (answer == "j")
            {
                System.Console.WriteLine("Vi går ut på picknick!");
            }
            else if (answer == "n")
            {
                System.Console.WriteLine("Vi stannar inne och läser en bok istället.");
            }             
            
        }
    }
}
