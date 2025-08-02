using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Binding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        public new void Fun01()
        {
            Console.WriteLine("Child class");
        }
        public override void Fun02()
        {
            Console.WriteLine($"TypeB: {A}, {B}");
        }
    }
   
}
