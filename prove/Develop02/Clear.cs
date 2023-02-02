using System;
using System.IO;
using System.Text;

public class Clear
{
    public void Run()
    {
        Console.Write("Which text file do you want to clear contents?: ");
        string fileName = Console.ReadLine();

        // Check if filename exists.
        if(File.Exists($"{fileName}"))
        {
            File.WriteAllText(fileName, "");
        }

        else
        {

        }
    }
}
