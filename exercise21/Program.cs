using System;

namespace exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Övning 21

            // Skapa ett program med menyval. I menyn får man välja att exekvera olika uppgifter. Alla menyalternativ ska ligga i metoder. 
            // Du kan ta någon uppgift från tidigare övningar men försök att hitta på egna metoder!

            double input;

            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("--------------Välkommen-----------");
            System.Console.WriteLine("------------Till räkna ut---------");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("----------------------------------\n");

            System.Console.WriteLine("Här kan du räkna ut olika scenarier:");

            while(true){
                
            System.Console.WriteLine("[1] Räkna ut hur snabbt du egentligen färdas i din bil.");
            System.Console.WriteLine("[2] Räkna ut momsen på en vara.");
            System.Console.WriteLine("[3] Räkna ut nettolönen.");
            System.Console.WriteLine("[4] Avsluta spelet.\n");
            System.Console.WriteLine("Mata in det du vill göra: ");
            int userInput = int.Parse(Console.ReadLine());

            
                switch(userInput)
                {
                    case 1: 
                    //Anropa SpeedInSeconds()
                    System.Console.WriteLine("Här får du en uppfattning i hur fort det egentligen går.");
                    System.Console.WriteLine("Skriv i km/h hur fort din bil färdas: ");
                    input = double.Parse(Console.ReadLine());
                    SpeedInSeconds(input);
                    break;

                    case 2:
                    //Anropa VaruMoms()
                    System.Console.WriteLine("Här räknar du ut hur mycket moms du betalar.");
                    System.Console.WriteLine("Vad kostar din vara?");
                    input = double.Parse(Console.ReadLine());
                    VaruMoms(input);
                    
                    break;

                    case 3: 
                    //Anropa TaxOfPayroll()
                    System.Console.WriteLine("Här får du reda på vad du tjänar efter skatt.");    
                    System.Console.WriteLine("Vad är din nuvarande månadslön?");             
                    input = double.Parse(Console.ReadLine());
                    TaxOfPayroll(input);
                    break;
                    
                    case 4:
                    //Avslutar (metoden main) spelet med return;
                    System.Console.WriteLine("Tack för att du spelade! Programmet avslutas");
                    return;
                    default: 

                    break;
                }
        }    
    }
        static double SpeedInSeconds(double speedInMeters)
       {
            Console.Clear();
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("I en hastighet av " + speedInMeters + " km/h färdas du: ");
            speedInMeters = Math.Round(speedInMeters * 1000 / 3600,2);    
            System.Console.WriteLine(speedInMeters + " meter i sekunden.");
            System.Console.WriteLine("----------------------------------------");
           

           return speedInMeters;
       }
    
        static double VaruMoms (double varaMedMoms)    
        {
            Console.Clear();
            double varaUtanMoms = varaMedMoms * 0.75;
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("Varan kostar " + varaUtanMoms + " kr utan moms.");
            varaUtanMoms = Math.Round (varaMedMoms * 0.25, 2);
            System.Console.WriteLine("Det innebär att momsen på varan är " + varaUtanMoms + " kr.");
            System.Console.WriteLine("----------------------------------------");


            return varaUtanMoms;
        } 

        static double TaxOfPayroll (double beforeTaxes)
        {
            Console.Clear();
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("Före skatt tjänar du alltså: " + beforeTaxes);
            double afterTaxes = Math.Round (beforeTaxes * 0.70, 2); 
            System.Console.WriteLine("Efter skatt så har du " + afterTaxes + " kr kvar att leva på.");
            System.Console.WriteLine("----------------------------------------");


            return afterTaxes;
        }
    }
}
