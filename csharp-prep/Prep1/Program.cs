using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first Name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string surname = Console.ReadLine();
        Console.WriteLine(" ");
        //Console.Write("Your name is ");
        //Console.Write(surname);
        //Console.Write(", ");
        //Console.Write(name);
        //Console.Write(" ");
        //Console.Write(surname);
        //Console.WriteLine(".");
        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}