using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "1969";
        public string Make { get; set; } = "Ford";

        public string Model { get; set; } = "Mustang";
        public abstract void  DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I love my {Model}");
        }

    }
}
