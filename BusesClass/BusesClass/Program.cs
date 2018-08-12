using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus();
            bus1.SetColour("blue");
            bus1.SetRego("ERT123");
            bus1.SetDoors(5);
            bus1.SetSeats(24);
            Console.WriteLine($"Colour: {bus1.GetColour()}\nRego: {bus1.GetRego()}\nDoors: {bus1.GetDoors()}\nSeats: {bus1.GetSeats()}");
        }
    }
}
