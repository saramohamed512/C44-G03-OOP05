using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Example01Interface
{
    internal interface ISeries
    {
        public int Current { get; set; }
        public void GetNextValue();
        public void ResetSeries() {
            // Default implementation for ResetSeries
            Current = 0; // Resetting current value to 0
            Console.WriteLine("Series has been reset.");
        }
    }
}
