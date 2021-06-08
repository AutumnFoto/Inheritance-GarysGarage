

using System;
namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Ram drives by");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram barrels to the {direction}!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Ram stops fast.");
        }
    }
}