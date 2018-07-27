using System;

namespace CG_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.");
            Console.WriteLine("Do you want to play a game?");
            Console.WriteLine("I'm thinking of a number 1 thru 10.");
            Console.WriteLine("Guess correctly and you win.");
            Console.WriteLine("Guess wrong and you lose.");
            Console.WriteLine("Let's begin.");

            string guess = Console.ReadLine();
            
            string message = (guess == "8") ? "You win!" : "You Lose!";

            Console.WriteLine(message);


            Console.ReadLine();

           
        }
    }
}
