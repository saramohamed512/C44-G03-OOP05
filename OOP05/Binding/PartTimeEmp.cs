using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Binding
{
    internal class PartTimeEmp: Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Hello PartTime Employee!");
        }
        public override void Fun02()
        {
            Console.WriteLine($"PartTimeEmp ID: {Id} | Name:{Name} | Age:{Age} | HourlyRate:{HourlyRate} | HoursWorked:{HoursWorked}");
        }
    }
}
