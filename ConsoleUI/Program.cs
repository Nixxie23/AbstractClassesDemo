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
             * Todo follow all comments!! 
             */

            #region Vehicles
            var vehicleList = new List<Vehicles>();
            Car winchesterCar = new Car() { Make = "Chevrolet", HasATrunk= true, Model = "Impala", Year = 1967 };
            Motorcycle robinCycle = new Motorcycle() { HasASideCar= true, Make = "Wayne", Model = "Crime fighting", Year = 2023 };
            Vehicles mysteryMachine = new Car() { Make = "Ford", Model = "Econoline", Year = 1978, HasATrunk= true };
            Vehicles hatchback = new Car() { Make = "Mazda", HasATrunk = false, Model = "CX-9", Year = 2017 };
            vehicleList.Add(winchesterCar);
            vehicleList.Add(mysteryMachine);
            vehicleList.Add(hatchback);
            vehicleList.Add(robinCycle);

            foreach(var veh in vehicleList) 
            {
                Console.WriteLine($" Make: {veh.Make} Model: {veh.Model} Year: {veh.Year}");
                veh.DriveVirtual();
                veh.DriveAbstract();                              
            }

           

            #endregion            
            
        }
    }
}
