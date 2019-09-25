using System;

namespace exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            // # Arrays
            // ## OBS! I dessa övningar ska du använda dig av undantagshantering i form av try & catch

            // ## Övning 11

            // Skriv ett program som hämtar flera tal från användaren, och som sedan skriver ut talen samt deras sammanlagda summa. 
            // Ni kan välja om ni vill använda hel eller decimaltal men ni måste använda en vektor för att spara undan talen. 
            //Använd for loop!
//-------------------------------------------------------------------------------------------------------------------------------------


            //skapar en array som tar emot fem nummer

            int [] numbers = new int[5];

            //skapar en variabel som lägger ihop alla inmatade nummer, för att få den att fungera i loopen måste den tilldelas ett värde (noll 0).

            int sumOfnumbers = 0;

            // skapar en for-loop som håller koll på att antalet inmatade nummer inte överstiger antalet index, samt plussar ihop talen.
            //Lägger även in min try - catch här, och var tvungen att lägga in en return i catchen för att få programmet att avslutas.
            for(int i = 0; i < numbers.Length; i++){
                try{
                System.Console.Write("Mata in ett nummer: ");
                numbers[i] = int.Parse(Console.ReadLine());
                }catch(Exception e){    

                    Console.WriteLine(e);
                    return;

                }  
            }
            
                Console.Clear();
                System.Console.WriteLine("Du har matat in:");
            
            //en for-loop som skriver ut alla värden i indexarna + sumofnumbers som varje iterrering plussar på för att få ut summan.
            for (int i = 0; i < numbers.Length; i++){
                System.Console.WriteLine(i + ". " + numbers[i]);
                sumOfnumbers = sumOfnumbers + numbers[i];
                
            }
            
            //skriver ut summan av de inmatade talen 
           
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("Summan är : " + sumOfnumbers);
            System.Console.WriteLine("-------------------------");
            
        }
    }
}
