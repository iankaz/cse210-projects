using System;

class Program
{
    static void Main(string[] args)
    {   
        // Prompt the user for their grade percentage
        Console.Write("What did you get on your final exam? ");

        string answer = Console.ReadLine();

        int percentage = int.Parse(answer);

        string letter = "";

        // Block of code of if and else statements from the user
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Display the user's grade letter
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
            // Added anather congratulatory message
            Console.WriteLine("Congratulations Student==from Professor Ian Kazembe");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}