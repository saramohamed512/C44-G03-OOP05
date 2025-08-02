using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Interface
{
    internal interface IType
    {
        // Properties
        public int MyProperty { get; set; }
        // Methods
        public void MyMethod();
        //default implemented methods
        public void Print()
        {
            Console.WriteLine("Default method called from IType interface.");
        }
    }
}
