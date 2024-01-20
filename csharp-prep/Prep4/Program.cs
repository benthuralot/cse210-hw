using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        
        //Create a list of integers. Call it numbers.
        List<int> numbers = new List<int>();

        //Prompt user to enter numbers to add to the list.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (true)
        {

        Console.Write("Enter number: ");
        //Save user input to a variable.
        string response = Console.ReadLine();
        //Parse user string into integer
        int inputNumber = int.Parse(response);
        
        //If inputNumber is '0' then break the loop.
        if (inputNumber == 0) 
            break;
        
            //.. Otherwise, add numbers to the list
            numbers.Add(inputNumber);          

        }
        
        //Compute sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Compute average
        float average = 0;

        average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find Largest Number
        int largestNum = 0;
        foreach (int num in numbers)
        {
            if (num > largestNum)
            {
                largestNum = num;
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");

    }
}