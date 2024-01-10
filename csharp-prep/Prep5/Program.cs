using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a function to print greeting (void because don't return any)
        static void DisplayWelcome (){
        Console.WriteLine("Welcome to the program sir/madam!");
        }
        //Use the function (summon)
        DisplayWelcome();


        //Create a function (with return string) asking for an user name
        static string PromptUserName(){
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            //Return the value (output)
            return userName;
        }
        
        //Create a function (with return intenger) asking for a number
        static int PromptUserNumber(){
            Console.Write("Please enter your favorite number: ");
            string favoriteNumber = Console.ReadLine();
            int favoriteNumberConvert = int.Parse(favoriteNumber);
            //Return the value converted (output)
            return favoriteNumberConvert;
        }
        
        //Create a function (with return intenger) to do a square from a number
        static int SquareNumber(int numberToConvertToSquare) {
            //Return the square of a number(output)
            return numberToConvertToSquare * numberToConvertToSquare;
        }

        //Create a function (with return string) to make a sentence
        static void DisplayResult (string userName,int squareNumber){
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
        }

        //Final output
        DisplayResult(PromptUserName(),SquareNumber(PromptUserNumber()));


    }




    
}