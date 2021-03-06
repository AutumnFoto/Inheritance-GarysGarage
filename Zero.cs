using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Zero drives by!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero shifts slightly to the {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Zero gently stops.");
        }
    }
}