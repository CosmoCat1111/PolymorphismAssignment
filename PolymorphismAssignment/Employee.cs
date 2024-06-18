using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Employee : IQuittable //calls interface
    {
        public void Quit() //implementing method
        {
            Console.WriteLine("Employee quits job!");
        }
    }
}
