using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
         
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        // Generate a random number for the magicNumber
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        // declare variables outside of the loop
        int guess = -1;
        int count = 0; 

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count ++; // guess count will increment with each guess.     
       
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You got in in {count} guesses.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Invalid input. Please type in a number.");
            }
        } while (guess != magicNumber); // Loop will go on for as long asthe guess != magicNumber
        
    }
}