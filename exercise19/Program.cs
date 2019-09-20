using System;

namespace exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
                // ## Övning 19
                // Skapa metoden ToPercentage() som tar in ett decimaltal och returnerar ett heltal.
                
                    System.Console.Write("Mata in ett decimaltal: ");
                try{
                    double input = double.Parse(Console.ReadLine());
                
                    ToPercentage(input);
                    
                }catch{
                    throw new Exception("Användaren matade in fel tecken..");
                }
                
        }

        static double ToPercentage (double DecimalToInt)
        {
                int convertedNumber = (int) DecimalToInt;
                

                System.Console.WriteLine("Ditt tal avrundat blir: " + convertedNumber);

                return convertedNumber;
        }
    }
}
