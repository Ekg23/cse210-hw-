using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start a breathing activity");
            Console.WriteLine("2. Start a listing activity");
            Console.WriteLine("3. Start a reflecting activty");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

            else if (choice == "3")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("You are quitting the program.");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice! Please choose a valid option.");
            }
        }
    }
}