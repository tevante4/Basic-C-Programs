using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        
            Console.WriteLine("Please enter the package weight.");
           int weight = Convert.ToInt32(Console.ReadLine()); //Converts the string into a int
            if (weight > 50) //if more than 50 stop
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
             Console.WriteLine("Please enter the package width:");
             int width = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Please enter the package height:");
             int height = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Please enter the package length:");
             int length = Convert.ToInt32(Console.ReadLine());
            if(height + length + width > 50) // if over 50 stop
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                }
            else
                {
                  int total = (height * length * width) * weight / 100; // Multiplies all the variables and divides by 100
                  Console.WriteLine("Your estimated total for shipping this package is:" + "$" + total + ".00");
                  Console.WriteLine("Thank You!");
                  Console.ReadLine();
                }
            }
        }
    }
}
