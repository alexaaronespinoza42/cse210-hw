using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int memberNumber = -1;
        while (memberNumber != 0)
        {
            Console.Write("Enter a number (0 to stop): ");
            string memberResponse = Console.ReadLine();
            memberNumber = int.Parse(memberResponse);

            if (memberNumber != 0)
            {
                numbers.Add(memberNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        /////////////////////////////////////////sum
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        /////////////////////////////////////////avg
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
        /////////////////////////////////////////max
    }
}