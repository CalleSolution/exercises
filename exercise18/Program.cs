using System;

namespace exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Övning 17
            // Skapa en metod som lägger till momsen på en viss summa. Antag att momsen är 25%.
            // ## Övning 18
            // Fortsättning på föregående övning. Gör om funktionen så att man i metodanropet (via parameterlistan) 
            //får ange vad momsen ligger på.
            double moms = 0;
            double vara = 0;
                System.Console.WriteLine("Du jobbar i en leksaksaffär, men affären har glömt att lägga till moms på alla varor");
                System.Console.WriteLine("Nu har du fått i uppgift att märka om alla priser.");
                System.Console.WriteLine("Momsen är bestämmer du själv, sedan kommer priset med moms att automatiskt att uppdateras.");

            try{
                System.Console.WriteLine("Hur många procent(%) moms vill du lägga på?");
                moms = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Hur mycket kostar varan?");
                vara = double.Parse(Console.ReadLine());
            }catch{
                throw new Exception("Användaren matade in fel tecken");
            }


                PriceWithMoms(moms, vara);
        }


        static double PriceWithMoms (double moms , double vara)
        {

            double userInputMoms = ( moms / 100 + 1 );
            double varaMedMoms = (userInputMoms * vara);
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Varan kostar nu: " + varaMedMoms + " kr.");
            System.Console.WriteLine("--------------------------------------");

            return varaMedMoms;
        }
    }
}
