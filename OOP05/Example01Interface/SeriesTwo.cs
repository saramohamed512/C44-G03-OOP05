using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Example01Interface
{
    internal class SeriesTwo: ISeries
    {
        public int Current { get; set; }
        public void GetNextValue()
        {
            // Implementation for getting the next value in the series
            Current += 3;
            Console.WriteLine($"Current value in SeriesTwo: {Current}");
        }
       
    }
   
}
