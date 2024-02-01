using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        // three properties
        public int Year { get; set; } = 2023;

        public string Make { get; set; } = "Toyota";

        public string Model { get; set; } = "Camry";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine(" driving a vehicle with virtual method");
        }

    }
}
