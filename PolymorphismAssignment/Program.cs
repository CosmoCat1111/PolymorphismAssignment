using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(); //creates instance of employee
            IQuittable quittable = emp; //polymorphism creates object of iquittable
            quittable.Quit(); //call the method
            Console.ReadLine();

        }
    }
}
