using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; } = true;

    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle is driving!");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle has a custom drive method.");
    }
}
