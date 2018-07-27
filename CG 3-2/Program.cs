using System;

namespace CG_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Opening up the program with lines to explain how the 
             * 'game' is played. */


            Console.WriteLine("Hello.");
            Console.WriteLine("Do you want to play a game?");
            Console.WriteLine("I'm thinking of a number 1 thru 10.");
            Console.WriteLine("Guess correctly and you win.");
            Console.WriteLine("Guess wrong and you lose.");
            Console.WriteLine("Please enter your guess.");

            /*This allows the user to input what they are guessing.*/


            string guess = Console.ReadLine();
            
            /*I originally was having issues with this bit of code beacause after
             * I had the information inputed nothing would write out on the 
             * screen.  In my class notes, I didn't write down that you had
             * to include the console.writeline command. I thought that maybe
             * that was what I was missing but I went back and watched
             * Bobo to verify that thought. */


            string message = (guess == "8") ? "You win!" : "You Lose!";

            Console.WriteLine(message);


            Console.ReadLine();

           
        }
    }
}
