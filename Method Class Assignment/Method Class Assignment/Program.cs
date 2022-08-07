using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = new Operation();

            oper.Multi(10, 20);
            oper.Multi(mult1: 10, mult: 4);
            Console.Read();

        }
    }
}