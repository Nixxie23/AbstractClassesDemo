using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicles
    {
        public bool HasASideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"This {Make} {Model} can be test driven if you have a motorcycle license.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("You need a motorcycle license to drive this.");
        }
    }
}
