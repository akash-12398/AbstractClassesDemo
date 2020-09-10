using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {



        public int Year { get; set; } = 2013;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Escape";

        public abstract void DriveAbstract();// stubbed out method

  
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
        



    }
            
   
}
