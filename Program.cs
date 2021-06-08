using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new vehicle for each class
            Cessna MyCessna = new Cessna();
            Ram MyRam = new Ram();
            Tesla MyTesla = new Tesla();
            Zero MyZero = new Zero();

            // adding properties to the vechicles 

            MyCessna.MainColor = "Dark Black";
            MyCessna.MaximumOccupancy = 4;
            MyCessna.FuelCapacity = 20;

            // invoke methods
            MyCessna.Drive();
            MyCessna.Turn("left");
            MyCessna.Stop();
            Console.WriteLine();

            MyRam.MainColor = "Bright Blue";
            MyRam.MaximumOccupancy = 2;
            MyRam.FuelCapacity = 18.1;

            MyRam.Drive();
            MyRam.Turn("right");
            MyRam.Stop();
            Console.WriteLine();

            MyTesla.MainColor = "Crimson Red";
            MyTesla.MaximumOccupancy = 5;
            MyTesla.BatteryKWh = 35.4;

            MyTesla.Drive();
            MyTesla.Turn("left");
            MyTesla.Stop();
            Console.WriteLine();



            MyZero.MainColor = "White";
            MyZero.MaximumOccupancy = 4;
            MyZero.BatteryKWh = 25.9;

            MyZero.Drive();
            MyZero.Turn("right");
            MyZero.Stop();
            Console.WriteLine();
        }
    }
}
