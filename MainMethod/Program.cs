﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Calls from Methods class to use here
            Methods methods = new Methods();

           
            //Console.WriteLine("Method Overloading. \nAll using Add method, let's utilize integers. First number please.");
            //int numA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("And the second integer please.");
            //int numB = Convert.ToInt32(Console.ReadLine());
            //int numC = methods.Add(numA, numB);


            //Console.WriteLine("Adding them together is: " + numC + "\nNow two decimals multiplied, returned as an integer. First number with a decimal please.");
            //decimal numD = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("And the second number with decimal please.");
            //decimal numE = decimal.Parse(Console.ReadLine());

            //int numF = methods.Add(numD, numE);
            //Console.WriteLine("Results: " + numF + ". \nNow to a method to convert string to integer and subract, if possible. \nFirst number please.");

            //string numG = Console.ReadLine();
            //Console.WriteLine("And number four:");
            //string numH = Console.ReadLine();

            //int numI = methods.Add(numG, numH);
            //Console.WriteLine("Results: " + numI);


            //Revised work - decalred variables rather than user input
            int a = 5;
            decimal b = 5.6M;
            string c = "5";

            //Calls Add method, demonstrates overloads for decimal and string
            int d = methods.Add(a);
            Console.WriteLine("Integer: 5 + 4 is: " + d);

            int e = methods.Add(b);
            Console.WriteLine("Decimal: 5.6 * 4 converted to an integer: " + e);

            int f = methods.Add(c);
            Console.WriteLine("String: 5 - 4: " + f);





            Console.ReadLine();    
        }
    }
}
