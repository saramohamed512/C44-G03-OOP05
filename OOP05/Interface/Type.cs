using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Interface
{
    // :  between 'interface' and 'class' keyword => implementation
    // :  between 'class' and 'class' keyword => inheritance
    internal class Type : IType 
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
