using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_answer = Console.ReadLine();
        int grade_percent = int.Parse(grade_answer);
        string grade_letter = "";
        string grade_symbol = "";


        if (grade_percent >= 90)
        {
            grade_letter = "A";
        }
        else if (grade_percent >= 80)
        {
            grade_letter = "B";
        }
        else if (grade_percent >= 70)
        {
            grade_letter = "C";
        }
        else if (grade_percent >= 60)
        {
            grade_letter = "D";
        }
        else
        {
            grade_letter = "F";
        }

        if (grade_percent % 10 >= 7)
        {
            grade_symbol = "+";
        }
        else
        {
            grade_symbol = "-";
        }

        if (grade_letter == "A" && grade_symbol == "+")
        {
            grade_symbol = "";
        }
        if (grade_letter == "F")
        {
            grade_symbol = "";
        }

        Console.WriteLine($"Your grade is: {grade_letter}{grade_symbol}");

        if (grade_percent >= 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, try again.");
        }
    }
}