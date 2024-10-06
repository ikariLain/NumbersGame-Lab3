using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a new instance of the Random class to generate random numbers
            Random random = new Random(); 


            int answer = random.Next(1, 20); 
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            // Initialize the number of attempts the player has made
            int tries = 0;

            // Loop until the player has had five tries
            while (tries < 5)
            {

                int input; //Storage the input from the user and resets after every loop till tries equals 5

                bool succes = int.TryParse(Console.ReadLine(), out input); // Check value is valid 
                
                if (succes)
                {
                    //Call method ChecGuess and after validating the input return tries to main method 
                    tries = CheckGuess(input, answer, tries); 

                    // if input equals answer than break the while loop.
                    if (input== answer)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Fel inmatning försök igen");
                }

            }
            // If the user guess wrong five times, display the answer
            if (tries>=5)
            {
                Console.WriteLine($"Det nu har du gjort fem försök, svaret var {answer}");
            }
           
        }
        // Method to check if the player's guess is correct or too high/low
        static int CheckGuess(int input, int answer,int tries) 
        {

            if (input == answer)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
            }
            else if (input > answer)
            {
                Console.WriteLine("Ditt tal är för hög");
                tries++;
            }   
            else
            {
                Console.WriteLine("Ditt tal är för låg");
                tries++;
            }
            // Return the updated number of attempts
            return tries;
        }
    }
}
