using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        Console.WriteLine(numbers.Count);

        int sum = 0;
        foreach (int usernumber in numbers)
        {
            sum += usernumber;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int bigNumber in numbers)
        {
            if (bigNumber > max)
            {
                max = bigNumber;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}