using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select an option");
        int menuOption;
        Display show = new Display();
        Entry menu = new Entry();
        Create makeFile = new Create();

        do
        {
            
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Write");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Clear file");
            Console.WriteLine("5. Quit");
            menuOption = int.Parse(Console.ReadLine());

            if (menuOption == 1)
            {
                makeFile.Display();
                
            }

            if (menuOption == 2)
            {
                menu.Run();
            }

            if (menuOption == 3)
            {
                show.Run();
            }

            if (menuOption == 4)
            {

            }
        } while (menuOption != 5);
    }
}