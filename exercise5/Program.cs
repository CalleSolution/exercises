using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
//             ## Övning 5

//     Inmatning och utmatning 

// -	I denna övning ska du göra ett program som låter användaren mata in sitt namn. 
//     Därefter hälsar du användaren välkommen. Du ska sedan låta användaren mata in sin ålder och spara undan den i lämplig variabel. 
//     Räkna sedan ut antalet dagar användaren har levt utifrån det angivna åldern. Presentera detta för användaren.

        //Hälsa användaren välkommen och mata in namn
        System.Console.WriteLine("Hej! Vad heter du?");
        string name = Console.ReadLine();
        System.Console.WriteLine("Välkommen " + name);

        //Låta användaren mata in sin ålder och omvandla det till antal dagar denne har levt.
        System.Console.WriteLine("Hur gammal är du? ");
        int age = int.Parse (Console.ReadLine());

        age = age * 365;


        System.Console.WriteLine(name + ". Du har levt i  "+ age + " dagar");

        }
    }
}
