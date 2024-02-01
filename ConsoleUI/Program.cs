using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> list = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            Car car1 = new Car(){ HasTrunk = true,Year = 2020, Make = "Ford", Model = "F-150", IsCovertible = true };
            Motorcycle motorcycle1 = new Motorcycle() { Year = 2020, Make = "BMW", Model = "S 1000 RR",HasSideCart = true, HasTwoWheels = true };
            Vehicle vehicle1 = new Car() { HasTrunk = true, Year = 2023, Make = "Ford", Model = "F-150", IsCovertible = true };           // we cannot use Vehicle instead of Car and Motorcycle, becaues Vehicle is static class and cannot be instenciated
            Vehicle vehicle2 = new Motorcycle() { Year = 2020, Make = "BMW", Model = "S 1200 RR", HasSideCart = true, HasTwoWheels = true } ;

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            list.Add(vehicle1);
            list.Add(vehicle2);
            list.Add(car1);
            list.Add(motorcycle1);


            // Call each of the drive methods for one car and one motorcycle

            motorcycle1.DriveAbstract();  // in abstrct = instance.method
            motorcycle1.DriveVirtual();

            Console.WriteLine(); // just to a space inbetween answers

            car1.DriveVirtual();
            car1.DriveAbstract();

            #endregion            
            Console.ReadLine();
        }
    }
}
