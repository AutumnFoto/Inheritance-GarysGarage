using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Cessna drives by");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna drives to the {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Cessna stops.");
        }
    }
}