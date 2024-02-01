using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool IsConvertible { get; set; }

        public bool HasTrunk { get; set; }
        public bool IsCovertible { get; internal set; }

        public override void DriveAbstract()
        {
            Console.WriteLine(" Driving a a car with an abstract mehtod");
        }
    }
}
