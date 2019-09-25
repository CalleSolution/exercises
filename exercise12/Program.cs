using System;

namespace exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Övning 12 

            // Alla namn (del 1)
            // Skapa en string array med fem element. 
            // Användaren får mata in fem namn via en for-loop. Programmet skriver sedan ut dessa namn med hjälp av en for-loop. 
            
            
            //skapar en string array med fem index
            string [] names = new string [5];

            //skapar en forloop där man får mata in namn i de fem indexen
            //skapar här en try catch också som håller koll att inmatningen är OK.
            for (int i = 0; i < names.Length; i++)
            {
                try{
                System.Console.Write("Mata in ett namn: ");
                names[i] = Console.ReadLine();
                }catch(Exception e)
                {
                    System.Console.WriteLine(e);
                    return;
                }
            }

            Console.Clear();
            //skapar en for-loop där namnen skrivs ut.

            for (int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine("På index " + i + " skrev du in " + names[i]);
            }


        }
    }
}
