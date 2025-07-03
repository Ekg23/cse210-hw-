using System;
using System.Data;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "";

        do
        {
            //Getting a random number from the computer
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);


            int number = -1;
            int count = 0;

            while (magicNumber != number)
            {
                Console.Write("Guess the number: ");
                string guess = Console.ReadLine();
                number = int.Parse(guess);
                //To count the number of guesses the user made
                count += 1;

                if (number < magicNumber)
                {
                    Console.WriteLine("Guess higer");
                }
                else if (number > magicNumber)
                {
                    Console.WriteLine("Guess lower");
                }
                else
                {
                    Console.WriteLine("You guessed it");
                    break;
                }
            }
            Console.WriteLine($"You guessed: {count} times.");
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine().ToLower();


        } while (response == "yes");
        
       

    }
}