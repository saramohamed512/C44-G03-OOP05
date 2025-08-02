using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Binding
{
    internal class FullTimeEmp: Employee
    {
        public decimal Salary { get; set; }
        public override void Fun01()
        {
            Console.WriteLine("Hello FullTime Employee!");
        }

        public override void Fun02()
        {
            Console.WriteLine($"FullTimeEmp ID: {Id} | Name:{Name} | Age:{Age} | Salary:{Salary}");
        }
    }
}
