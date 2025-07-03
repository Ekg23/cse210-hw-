using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = -1;


        while (num != 0)
        {
            Console.Write("Enter a list of number, type 0 when done. ");
            string answer = Console.ReadLine();
            num = int.Parse(answer);



            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        // Sum of a numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;

        }
        Console.WriteLine($"The sum is {sum}");


        //Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        //Largest number in the list
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is {max}");

        // smallest positive number in the list
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min && number > 0)
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest positive number is {min}");

        //sorting the list in ascending order
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine("The sorted list is: ");
            Console.WriteLine(number);
        }
    }
}