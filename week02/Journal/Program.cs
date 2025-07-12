using System;
using System.ComponentModel;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
 
        while (true)
        {
            Console.WriteLine("Welcome to my Journal Program");
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Exit");

            Console.Write("What would you like to do: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);
                Console.WriteLine("Entry added.\n");

            }
            else if (choice == "2")
            {
                Console.WriteLine("\nYour Journal Entries:");
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Entries saved.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Entries loaded.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("You are exiting the program");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, Please make select a valid option");
            }

        }
    }
}