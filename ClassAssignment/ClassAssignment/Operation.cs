﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Operation
    {
        public void Div(int num)
        {
            int result = num / 2;
            Console.WriteLine("This is your number divided by 2:\n{0}", result);
        }

        public void Mult(int num = 3)
        {
            int result = num * 3;
            Console.WriteLine("This is 3 multiplied by 3:\n{0}", result);
        }

        public int Subt(int num, out int num1)
        {
            num1 = 4;
            int result = num - num1;
            Console.WriteLine("This is your first number, {0}, subtracted from second number {1}:\n{2}", num, num1, result);
            return num1;

        }
        public int Mult(int num, int num1)
        {
            int result = num * num1;
            return result;
        }




    }
}