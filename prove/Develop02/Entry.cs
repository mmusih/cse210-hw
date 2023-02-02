using System;
using System.IO;
public class Entry
{
   public void Run()
   {
      int answer;
      string userInput;
      Random random = new Random();
      Create saveFile = new Create();

      Console.WriteLine(@"Please select and option: 
      1. Get a prompt
      2. Write without prompt");

      answer = int.Parse(Console.ReadLine());
      
      if (answer == 1)
      {
         string[] journalQuestions = {
      "What made this day memorable?",
      "Did you meet anyone intresting?",
      "What are you grateful for today?",
      "Did you learn anything new?",
      "If you could change anything that happened today? what could it be?",
      "Have you archieved all which you planned today?",
      "Did you make the Lord part of your life today?",
      "What were your feelings when you prayed this morning?"};
                                    
         // Generate random indexes for journalQuestions.
         int mIndex = random.Next(journalQuestions.Length);

         // Display the result.
         Console.WriteLine(journalQuestions[mIndex]);

         string write = Console.ReadLine();
         string currentDate1 = DateTime.Now.ToString("MM/dd/yyyy");

         Console.Write("What is the file name to save to?: ");
         string fileInput = Console.ReadLine();
         string fileName = fileInput;
      
         if (File.Exists($"{fileName}"))
            {
               File.AppendAllText(fileName, $"\nEntry\n:> {currentDate1} {write}");
            } 
         else
         {
            File.CreateText($"{fileName}");
            File.AppendAllText(fileName, $"\nEntry\n:> {currentDate1} {write}");
         }

         }

         
      
      else
      {
         Console.WriteLine("Write your entry:__");
         userInput = Console.ReadLine();

         string currentDate1 = DateTime.Now.ToString("MM/dd/yyyy");

         Console.Write("What is the file name: ");
         string fileInput = Console.ReadLine();
         string fileName = fileInput;

         if (File.Exists($"{fileName}"))
            {
               File.AppendAllText(fileName, $"\nEntry\n:> {currentDate1} {userInput}");
            } 
         else
         {
            File.CreateText($"{fileName}");
            File.AppendAllText(fileName, $"\nEntry\n:> {currentDate1} {userInput}");
         }

      }
   }
}