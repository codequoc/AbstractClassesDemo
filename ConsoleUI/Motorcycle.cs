using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public override void DriveAbstract()
        {
            Console.WriteLine("This motercycle is in Drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is in Virutal Drive");
        }

        public bool HasSideCart { get; set; }
    }
}
