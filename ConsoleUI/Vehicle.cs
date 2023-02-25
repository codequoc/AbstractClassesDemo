using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "default Make";
        public string Model { get; set; } = "default Model";

        public abstract void DriveAbstract();
        
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This is virtually in drive");
        }

    }
}
