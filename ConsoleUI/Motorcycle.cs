using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public bool HasTwoWheels { get; set; } = true;


        public override void DriveAbstract()
        {
            Console.WriteLine(" driving a motorcycle with an abstarct method");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine(" driving a motorcycle with an virtual method");
        }

    }
}
