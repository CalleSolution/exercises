using System;

namespace exercise13
{
    class Program
    {
        static void Main(string[] args)
        {     
            // ## Övning 13

            // 3.	Väderstationen
            // Denna övning påminner om den förra, men man skriver inte i början hur många mätningar som ska göras. 
            // Allt sköts via en meny istället.
            // När man väljer att ta bort en temperaturmätning, så anger man vilken mätning man vill ta bort med hjälp av index. 
            // Bestäm själv om du använder for eller foreach. Motivera gärna ditt val i koden. 
            //-------------------------------------------------------------------------------------------------------------------

            // deklarerar en variabel som läser av hur många mätningar som skall göras.
            int measurement = 0;

            //Välkomnar och läser av antalet mätningar samt en try catch för att stämma av att inmatningarna sker korrekt.
            try{
            System.Console.WriteLine("Välkommen till väderstationen, här skriver du in hur många mätningar du vill göra: ");
            measurement = int.Parse(Console.ReadLine());
            }catch{
                throw new Exception("Användaren matade in fel tecken");
            }
            // Lägger till antalet mätningar i en skapad vektor. Vektorn måste ligga under inmatningen av antalet mätningar
            //Annars får inte vektorn något värde.
            int [] qtyOfMeasurment = new int [measurement];

            //En for-loop som räknar in antalet temperaturer som lagts in
            for (int i = 0; i < qtyOfMeasurment.Length; i++)
            {
                try{
                System.Console.WriteLine("Skriv in din uppmätta temperatur: ");
                qtyOfMeasurment[i] = int.Parse(Console.ReadLine());
                }catch(Exception e){
                        System.Console.WriteLine(e);
                        return;
                }
            }
            
            // en halvt misslyckad do-while loop som loopar hela tiden, dock loopar den om så att mätningarna skrivs ut igen även om man 
            // tagit bort en eller flera mätningar.
            do{

                //Ytterligare en for-loop som skriver ut värdet av de mätningar som gjorts.
            for(int i = 0; i < qtyOfMeasurment.Length; i++)
            {
                System.Console.WriteLine("mätning "+ i  + " uppgavs till "+ qtyOfMeasurment[i] + " grader C.");
            }

            // Deklarerar variabel för att kunna ta bort ett specifikt index i vektorn.
            int erase = 0;
            // try catch som kontrollerar att inga tokigheter sker i syntaxen, samt en inmatning för att ta bort ett specifikt index.
            try{
            System.Console.WriteLine("Ta bort valfritt index: ");
            erase  = int.Parse(Console.ReadLine());
            qtyOfMeasurment[erase] = 0;
            }catch (Exception e){
                System.Console.WriteLine(e);
            }
            }while (true);
        }
    }
}
