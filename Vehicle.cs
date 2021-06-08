using System;

namespace Garage
{
    public class Vehicle
    //  inheritance
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}