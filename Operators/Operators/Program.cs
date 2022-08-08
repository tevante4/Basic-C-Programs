using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Tevante";
            employee.LastName = "Testing";
            employee.Id = 2;

            Employee employee2 = new Employee() { FirstName = "Billy", LastName = "Sobu", Id = 8 };

            Console.WriteLine(employee == employee2);
            Console.ReadLine();

        }
    }
}