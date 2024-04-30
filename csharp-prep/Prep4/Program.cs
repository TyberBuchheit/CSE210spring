using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter a number, then enter 0 when you're finished: ");

            string inputNumber = Console.ReadLine();
            userInput = int.Parse(inputNumber);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}