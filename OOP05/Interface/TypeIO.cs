using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Interface
{
    internal class TypeIO : IType
    {
        public int MyProperty
        {
            get;
            set;
        }

        public void MyMethod()
        {
            Console.WriteLine("MyMethod called from Type class.");
        }
    }
}
