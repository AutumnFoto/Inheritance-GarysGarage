
using System;
namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Tesla drives by! ");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Telsa turns {direction} on its own!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Telsa stops moving.");
        }
    }
}