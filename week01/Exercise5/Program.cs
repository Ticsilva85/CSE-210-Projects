using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Week 01 - Exercise 5 - Assignment

        Console.WriteLine("");
        Console.WriteLine("=======================================================");
        Console.WriteLine("             Week 01 Assignment - Functions            ");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your user name? ");
            string user = Console.ReadLine();

            return user;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string number = Console.ReadLine();
            int favnumber = int.Parse(number);

            return favnumber;
        }

        static int SquareNumber(int num)
        {
            int sqrNum = num * num;

            return sqrNum;
        }

        static void DisplayResult()
        {
            string name = PromptUserName();
            int favorite = PromptUserNumber();
            double squareNum = SquareNumber(favorite);

            Console.WriteLine($"{name}, the square number of {favorite} is {squareNum}.");
        }

        DisplayWelcome();
        DisplayResult();
    }
}