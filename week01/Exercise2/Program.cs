using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Letter Grade Calculation");
        Console.WriteLine("");

        Console.WriteLine("Hello. Inform your grade percentage: ");
        string gradePercent = Console.ReadLine();
        int gradeValue = int.Parse(gradePercent);

        string letter;

        // Determine Grade Letter
        if (gradeValue >= 90)
        {
            letter = "A";
        }

        else if (gradeValue >= 80)
        {
            letter = "B";
        }

        else if (gradeValue >= 70)
        {
            letter = "C";
        }

        else if (gradeValue >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        // Determine the sign
        int lastDigit = gradeValue % 10;
        string sign;

        if (letter == "F" || gradeValue >= 93)
        {
            sign = "";
        }

        else if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        // Passed information
        Console.WriteLine("");
        Console.WriteLine($"Your grade letter is {letter}{sign}");

        if (gradeValue >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("Sorry, you didn't pass. Keep trying!");
        }
    }
}