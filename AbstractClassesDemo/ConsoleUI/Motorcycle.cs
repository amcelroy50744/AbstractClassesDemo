using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() 
        {
        
        }
        public bool hasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"This is a {Model}");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"I can not drive a {Model}");
        }
    }

}
