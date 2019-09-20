using System;

namespace exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en metod som lägger till momsen på en viss summa. Antag att momsen är 25%.
            double vara = 0;
            System.Console.WriteLine("Du jobbar i en leksaksaffär, men affären har glömt att lägga till moms på alla varor");
            System.Console.WriteLine("Nu har du fått i uppgift att märka om alla priser.");
            System.Console.WriteLine("Momsen är 25%, om du matar in vad varan kostar just nu så kommer momsen automatiskt att uppdateras.");
            try{
            System.Console.WriteLine("Hur mycket kostar varan?");
            vara = double.Parse(Console.ReadLine());
            }catch{
                throw new Exception("Användaren matade in fel tecken");
            }
            PriceWithMoms(vara);
        }
        static double PriceWithMoms (double vara)
        {
            double varaMedMoms = (vara *1.25);

            System.Console.WriteLine("Varan kostar nu: " + varaMedMoms);

            return varaMedMoms;
        }
    }
}
