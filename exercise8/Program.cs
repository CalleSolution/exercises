using System;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
        //     # Switch
        //     ## Övning 8

        //     Banksimulatorn
        // -	Skriv ett program som simulerar en bank. Man ska kunna sätta in pengar och ta ut pengar, samt kolla saldo. 
        //     Detta görs via en meny som du ska göra med switch-sats. Observera att du bör jobba med loopar i denna uppgift!
                
                
                // Skapar två variabler som har koll på saldot, ett för det gamla saldot och ett för det nya, för att kunna uppdatera saldot korrekt.  
                    int gammaltSaldo = 0;
                    int uppdateratSaldo = 0;
                //Välkomst-text med menyalternativ samt deklarerad variabel menuChoice för att läsa av valt alternativ.
                    System.Console.WriteLine("Välkommen till banken, välj något av följande alternativ:");

                while(true){
                    
                    System.Console.WriteLine("[1] Sätt in pengar");
                    System.Console.WriteLine("[2] Ta ut pengar");
                    System.Console.WriteLine("[3] Kolla saldo");
                    System.Console.WriteLine("[4] Avsluta");
                    
                    int menuChoice = int.Parse(Console.ReadLine());

                    //Switch-sats med de olika alternativen

                    switch(menuChoice){

                        case 1: 
                        System.Console.WriteLine("Sätt in pengar: ");
                        gammaltSaldo = int.Parse(Console.ReadLine());
                        uppdateratSaldo = gammaltSaldo + uppdateratSaldo;
                        
                        break;

                        case 2: 
                        System.Console.WriteLine("Ta ut pengar: ");
                        gammaltSaldo = int.Parse(Console.ReadLine());
                        uppdateratSaldo = uppdateratSaldo - gammaltSaldo;
                        
                        break;

                        case 3: 
                        System.Console.WriteLine("Du har " + uppdateratSaldo + " kr på ditt konto."); 
                        break;

                        case 4:
                        System.Console.WriteLine("Programmet avslutas, tack för att du valde vår bank."); 
                        return;

                        default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Felaktig inmatning");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }

        }
    }
}
