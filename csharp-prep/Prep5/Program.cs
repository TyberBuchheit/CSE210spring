using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.Write("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, when squared your favorite number is: {square}");
    }
}