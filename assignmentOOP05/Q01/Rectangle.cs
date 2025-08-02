using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q01
{

    public class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area => Length * Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with length {Length} and width {Width} has area {Area:F2}");
        }
    }
}
