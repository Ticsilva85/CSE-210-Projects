using System;
using System.IO;

// Exceeds core requirements:
// Each journal entry records the user's mood in addition to
// the date, prompt, and response. The mood is displayed and
// preserved when saving and loading the journal.
//
// Additional improvements:
// The program rejects empty responses and invalid menu choices.
// File errors are handled without closing the program.
// Loading validates the entire file before replacing current entries.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = (Console.ReadLine() ?? "5").Trim();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                {
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(response))
                    {
                        Console.WriteLine(
                            "The response cannot be empty. Entry not added.");
                        break;
                    }

                    Console.Write("How are you feeling today? ");
                    string mood = (Console.ReadLine() ?? "").Trim();

                    if (string.IsNullOrWhiteSpace(mood))
                    {
                        mood = "Not specified";
                    }

                    // This separator is reserved for the file format.
                    if (mood.Contains("~|~"))
                    {
                        Console.WriteLine(
                            "Please do not use ~|~ in your mood. Entry not added.");
                        break;
                    }

                    Entry entry = new Entry();

                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;
                    entry._mood = mood;

                    journal.AddEntry(entry);

                    Console.WriteLine(
                        "Entry added. Choose Save to keep it in a file.");
                    break;
                }

                case "2":
                {
                    journal.DisplayAll();
                    break;
                }

                case "3":
                {
                    Console.WriteLine(
                        "Loading will replace the entries currently in memory.");
                    Console.Write("Enter the filename to load (example: journal.txt): ");

                    string file = (Console.ReadLine() ?? "").Trim();

                    if (string.IsNullOrWhiteSpace(file))
                    {
                        Console.WriteLine("The filename cannot be empty.");
                        break;
                    }

                    try
                    {
                        journal.LoadFromFile(file);
                        Console.WriteLine("Journal loaded successfully.");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"Could not load the file: {ex.Message}");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine(
                            "You do not have permission to read this file.");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Please enter a valid filename.");
                    }
                    catch (NotSupportedException)
                    {
                        Console.WriteLine("This file path format is not supported.");
                    }

                    break;
                }

                case "4":
                {
                    Console.WriteLine(
                        "Saving will overwrite the file if it already exists.");
                    Console.Write("Enter the filename to save (example: journal.txt): ");

                    string file = (Console.ReadLine() ?? "").Trim();

                    if (string.IsNullOrWhiteSpace(file))
                    {
                        Console.WriteLine("The filename cannot be empty.");
                        break;
                    }

                    try
                    {
                        journal.SaveToFile(file);
                        Console.WriteLine("Journal saved successfully.");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"Could not save the file: {ex.Message}");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine(
                            "You do not have permission to write to this file.");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Please enter a valid filename.");
                    }
                    catch (NotSupportedException)
                    {
                        Console.WriteLine("This file path format is not supported.");
                    }

                    break;
                }

                case "5":
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                default:
                {
                    Console.WriteLine(
                        "Invalid choice. Please enter a number from 1 to 5.");
                    break;
                }
            }
        }
    }
}