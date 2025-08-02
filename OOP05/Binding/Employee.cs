using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Fun01()
        {
                Console.WriteLine("Hello Employee!");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"Emp ID: {Id} | Name:{Name} | Age:{Age}");
        }
    }
}
