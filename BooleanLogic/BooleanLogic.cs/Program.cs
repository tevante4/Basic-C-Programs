using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age?");
            string writtenAge = Console.ReadLine();
            int userAge = Convert.ToInt32(writtenAge);

            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            string writtenDUI = Console.ReadLine();
            bool userDUI = Convert.ToBoolean(writtenDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string writtenTickets = Console.ReadLine();
            int userTickets = Convert.ToInt32(writtenTickets);

            //boolean operation that says if the user age is greater than 15 and the user has less than 3 tickets and if the user does not have any DUIs then they are qualified.
            bool isAuthorized = (userAge > 15 && userTickets < 3 && userDUI == false);
            Console.WriteLine("Qualified?");
            Console.WriteLine(isAuthorized);
            Console.ReadLine();

        }
    }
}
