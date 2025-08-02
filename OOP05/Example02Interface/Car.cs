using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Example02Interface
{
    internal class Car :Vehicla, IMoveOnGround
    {
        public int Speed { get; set; }
        public void Backward()
        {
           Console.WriteLine("Car is moving backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car is moving forward");
        }

        public void left()
        {
            Console.WriteLine("Car is turning left");
        }

        public void Right()
        {
            Console.WriteLine("Car is turning right");
        }
    }
}
