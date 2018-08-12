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
            Console.WriteLine("Enter bus colour: ");
            bus1.SetColour(Console.ReadLine());
            Console.WriteLine("Enter bus rego: ");
            bus1.SetRego(Console.ReadLine());
            Console.WriteLine("Enter number of bus doors: ");
            bus1.SetDoors(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter number of bus seats: ");
            bus1.SetSeats(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Colour: {bus1.GetColour()}\nRego: {bus1.GetRego()}\nDoors: {bus1.GetDoors()}\nSeats: {bus1.GetSeats()}");
        }
    }
}
