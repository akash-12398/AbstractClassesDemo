using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSeat { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Motocycle is in drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
