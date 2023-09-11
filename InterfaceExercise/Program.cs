using System;
using System.Collections.Generic;
using System.Reflection;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces


            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
            Car car1 = new Car()
            {
                CanOffRoad = true,
                CanFitInGarage = "should fit in any garage!",
                Logo = "BMW",
                Slogan = "Sheer driving pleasure",
                RunsWell = true,
                HasWindows = "race cars need windows",
                TravelsDistance = "A bmw will take you wherever yopur heart desires!!",
                HasAnEngine = true,
            };




            Truck truck1 = new Truck()
            {
                HasBed = true,
                Slogan = "built ford tough",
                CanWork = true,
                HasWindows = "trucks need windows for those dirt roads! ",
                TravelsDistance = "trucks are the most reliable transportation: just an opinion.",
                HasAnEngine = true,
                Logo = "FORD= fix or repair daily",
            };



            SUV suv1 = new SUV()
            {
                Slogan = "if ya ain't first your last",
                HasThirdRow = "They have third row seating.",
                CanFitFamily = true,
                HasWindows = "they must have windows to keep the kiddos happy.",
                TravelsDistance = "the best road trip vehicle their is.",
                HasAnEngine = true,
                RunsWell = true,
                Logo = "Ram",

            };
            List<IVehicle> vehicles = new List<IVehicle>() { truck1, suv1, car1 };
            //List<ICompany> companys = new List<ICompany>() { truck1, suv1, car1 };
            foreach (IVehicle vehicle in vehicles)
            {
                if (vehicle is ICompany name)
                {
                    Console.WriteLine(name.Logo);
                    Console.WriteLine(name.Slogan);
                }
                Console.WriteLine($"{vehicle.GetType().Name}");
                Console.WriteLine($"Has Windows!! {vehicle.HasWindows}");
                Console.WriteLine($"Travels a distance. {vehicle.TravelsDistance}");
                Console.WriteLine($"They have to run well {vehicle.RunsWell}");
                Console.WriteLine($"Has to have an engine?? {vehicle.HasAnEngine}");
                Console.WriteLine();

            }





            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }

}