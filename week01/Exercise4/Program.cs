using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Practice for Week 01 - Exercise 4:
        // List<String> fruits = new List<string>();

        // fruits.Add("Apple");
        // fruits.Add("Banana");
        // fruits.Add("Cherries");
        // fruits.Add("Starfruit");

        // foreach (string fruit in fruits)
        // {
        //     Console.WriteLine(fruit);
        // }

        // Console.WriteLine("");
        // Console.WriteLine(fruits.Count);

        // Console.WriteLine("");
        // for (int i = 0; i < fruits.Count; i++)
        // {
        //     Console.WriteLine(fruits[i]);
        // }

        // Week 01 - Exercise 4 - Assignment

        Console.WriteLine("");
        Console.WriteLine("============================================");
        Console.WriteLine("                 Numbers List               ");
        Console.WriteLine("============================================");
        Console.WriteLine("");

        int number;
        List<int> numList = new List<int>();

        do
        {
            Console.WriteLine("Enter a positive or negative number (0 to finish):");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numList.Add(number);
            }
            
        } while (number != 0);

        Console.WriteLine("");
        Console.WriteLine("Your numbers are:");

        foreach (int num in numList)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("");

        // Check if the list is empty
        if (numList.Count > 0)
        {
            int sum = 0;
            int largest = numList[0];

            foreach (int num in numList)
            {
                sum += num;

                if (num > largest)
                {
                    largest = num;
                }
            }

            double average = (double)sum /numList.Count;

            Console.WriteLine($"The sum of the number in the list is: {sum}");
            Console.WriteLine($"The largest number of the list is: {largest}");
            Console.WriteLine($"The average number of the list is: {average}");

            // Stretch Challenge
            int smallestPositive = 0;

            foreach (int num in numList)
            {
                if (num > 0)
                {
                    if (smallestPositive == 0 || num < smallestPositive)
                    {
                        smallestPositive = num;
                    }
                }
            }

            if (smallestPositive> 0)
            {
                Console.WriteLine($"The smallest positive is: {smallestPositive}");
            }

            else
            {
                Console.WriteLine("There are no positive numbers in the list.");
            }

            // Sort the list
            numList.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int num in numList)
            {
                Console.WriteLine(num);
            }
        }

    }
}