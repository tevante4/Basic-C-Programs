using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the vowel?");
            string letter = Console.ReadLine();
            bool isGuessed = letter == "t"; // is true if the typed letter is u
            int i = 0;
            while (i < 10) //loops until i gets to 10
            {
                Console.WriteLine(i);
                i++; //adds 1 
            }    
            do //does the loop after the first input
            {
                switch (letter)
                {
                    case "a":
                        Console.Write("You guessed a. Try again. ");
                        Console.WriteLine("Guess a vowel?");
                        letter = Console.ReadLine();
                        break;
                    case "u":
                        Console.WriteLine("You guessed u. Try again. ");
                        Console.WriteLine("Guess a vowel?");
                        letter = Console.ReadLine();
                        break;
                    case "e":
                        Console.WriteLine("You guessed e. Thats correct!");
                        isGuessed = true; //this stops the loop.
                        break;
                    default:
                        Console.WriteLine("Your Wrong. Try again. ");
                        Console.WriteLine("Guess a vowel?");
                        letter = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed); //Starts the loop
            Console.Read();
        }
    }
}
