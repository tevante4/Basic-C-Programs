using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOne math = new ClassOne();

            Console.WriteLine("Please enter two numbers one at a time. A second number is not necessary.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            try
            {
                int userNumber2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(math.ExampleOne(userNumber, userNumber2));
                Console.ReadLine();
            }
            catch //passing the catch statement like an else statement. 
            {
                Console.WriteLine(math.ExampleOne(userNumber)); //this will use the user input for userNumber and the default value from the method for userNumber2
                Console.ReadLine();
            }
        }
    }
}
