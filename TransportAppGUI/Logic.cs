using ClassLibrary1;
using System;

namespace TransportApp
{
    public static class TransportLogic
    {
        public static void PrintTransportInfo(Abstract_Transport_by_wheels transport)
        {
            Console.WriteLine($"Name: {transport.Name}");
            Console.WriteLine($"Capacity: {transport.Capacity}");
            Console.WriteLine($"Type of Energy: {transport.Type_of_energy}");
            Console.WriteLine($"Number of Wheels: {transport.Numbers_of_wheels}");
            Console.WriteLine($"Price: {transport.Price}");
            Console.WriteLine($"Stops: {string.Join(", ", transport.Stops)}");
        }

        public static int CalculateFare(Abstract_Transport_by_wheels transport)
        {
            return transport.Price * transport.Capacity;
        }
    }
}
