using System;

namespace exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Övning 20
            // Skapa en metod som kontrollerar om man är myndig. Metoden ska ta in ett heltal och returnera true eller false.

                int ageOfUser;

                System.Console.WriteLine("Hur gammal är du?");
                try{
                ageOfUser = int.Parse(Console.ReadLine());

                AgeCheck(ageOfUser);
                }catch{
                    throw new Exception("Användaren matade in fel tecken..");
                }

            
        }
        static int AgeCheck(int ageOfUser)
        {
            bool isMyndig = true;

            if (ageOfUser >= 18){
                System.Console.WriteLine("Du är: " + isMyndig);
            }else{
            isMyndig = false;
            System.Console.WriteLine("Du är: " + isMyndig);
            }
            return ageOfUser;
        }
    }
}
