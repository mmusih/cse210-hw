using System;
using System.IO;
using System.Text;

public class Create
{
    public string fileName;
    public void Display()
    {
        Console.Write("What is the file name: ");
        string fileName = Console.ReadLine();

        // Check if filename exists and if it does not create it.
        if(!File.Exists($"{fileName}"))
        {
            File.CreateText($"{fileName}").Close();
        }
    }
}
