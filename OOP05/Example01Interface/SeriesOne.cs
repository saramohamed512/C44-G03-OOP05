using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Example01Interface
{
    internal class SeriesOne : ISeries
    {
        public int Current { get; set; }
        public void GetNextValue()
        {
            // Implementation for getting the next value in the series
            Current+=2;
            Console.WriteLine($"Current value in SeriesOne: {Current}");
        }
        
    }
    
}
