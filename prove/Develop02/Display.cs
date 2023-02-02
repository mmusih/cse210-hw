using System;
using System.IO;

public class Display
{
    
    public void Run()
    {
        Console.WriteLine("What is the name of the file you want to open: ");
        string fileName = Console.ReadLine();
    
        if(File.Exists($"{fileName}"))
            {
            string journalText = File.ReadAllText(fileName);
            Console.WriteLine(" ");
            Console.WriteLine("Your entries are: ");
            Console.WriteLine(journalText);
            }
        else
        {

        }
    }
}