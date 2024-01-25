using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
            {
            Console.Write("Please enter the name of the author of the verse: ");
            string reference = Console.ReadLine();

            Console.Write("Please write your Bible verse of the Day: ");
            string text = Console.ReadLine();

            Scripture scripture = new Scripture(reference, text);
            Word game = new Word(scripture);
            game.Play();
        }

    }
}