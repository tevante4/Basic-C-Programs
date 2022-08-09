using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string greet = "Hello"; //creating constant

            var name = "Tevante"; //assigning implicit variable           



            Console.WriteLine(greet + " " + name); //concatenating together

            Console.Read();

            myClass test = new myClass("Tevante");
        }
        public class myClass
        {
            string name = "Drew";
            public myClass() : this("Tevante")
            {
            }
            public myClass(string name)
            {
                this.name = name;
            }

        }

    }
}