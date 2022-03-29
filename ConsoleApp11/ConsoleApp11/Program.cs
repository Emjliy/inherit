using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "X6");
            car.info();
            Car bus = new Bus("BMW", "X6", "white", 300, 5);
            bus.info();
        }

    }
}
