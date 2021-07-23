using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
     public class Car: Vehicle
    {
        public Car() 
        {
        }
        public string carSize { get; set; } = "Sedan";
        public override void DriveAbstract()
        {
            Console.WriteLine($"This is a {Model}");
        }
    }
    
}
