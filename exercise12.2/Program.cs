using System;

namespace exercise12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Övning 12 

            // Alla namn (del 1)
            // Skapa en string array med fem element. Användaren får mata in fem namn via en for-loop. 
            // Programmet skriver sedan ut dessa namn med hjälp av en for-loop. 

            // Alla namn (del 2)
            // Efter att alla namn skrivits ut, ska användaren kunna skriva ett index och därefter ett annat namn. 
            // Personen på detta index i arrayen byts då ut och alla namn skrivs ut igen. Om användaren istället skriver ”q” eller ”Q” 
            // så avslutas programmet direkt.
//-------------------------------------------------------------------------------------------------------------------------------------



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
            while(true)
            {
                    for (int i = 0; i < names.Length; i++)
                    {
                        System.Console.WriteLine("På index " + i + " skrev du in " + names[i]);
                    }

                    //Läser av om användaren vill ändra något index eller avsluta spelet. Samt en try catch som kontrollerar inmatning.
                    try{
                    System.Console.WriteLine("Tryck 0-4 för att byta namn på index. Tryck q för att avsluta");
                    string changeName = Console.ReadLine();
                    changeName = changeName.ToLower();
                    }catch(Exception e)
                    {
                        System.Console.WriteLine(e);
                    }
                    //Switch case som känner av vilken inmatning som görs.
                    switch(changeName)
                    {
                        case "0":
                        System.Console.WriteLine("Vilket namn föredrar du på index 0?");
                        names[0] = Console.ReadLine();
                        break;
                        case "1":
                        System.Console.WriteLine("Vilket namn föredrar du på index 1?");
                        names[1] = Console.ReadLine();
                        break;
                        case "2":
                        System.Console.WriteLine("Vilket namn föredrar du på index 2?");
                        names[2] = Console.ReadLine();
                        break;
                        case "3":
                        System.Console.WriteLine("Vilket namn föredrar du på index 3?");
                        names[3] = Console.ReadLine();
                        break;
                        case "4":
                        System.Console.WriteLine("Vilket namn föredrar du på index 4?");
                        names[4] = Console.ReadLine();
                        break;
                        case "q":
                        System.Console.WriteLine("Tack för att du spelade!");
                        return;
                        default:
                        System.Console.WriteLine("Förstår inte. Programmet avslutas. ");
                        return;
                        
                    }
            }

        }
    }
}
