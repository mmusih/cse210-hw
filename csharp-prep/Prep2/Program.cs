using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Percentage? ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);
        
        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");
            if (score >= 70)
            {
                Console.WriteLine("Congratulations you have PASSED!");
            }
            else
            {
                Console.WriteLine("You have failed the exam, good luck on your next attempt.");
            }

    }
}