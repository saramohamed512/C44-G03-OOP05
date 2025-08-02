using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Binding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a)
        {
            A = a;
        }
        public void Fun01()
        {
                        Console.WriteLine("Parent class");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"TypeA: {A}");
        }
    }
}
