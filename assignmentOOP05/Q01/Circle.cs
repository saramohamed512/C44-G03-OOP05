using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q01
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }


        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius {Radius} has area {Area:F2}");
        }
    }
}
