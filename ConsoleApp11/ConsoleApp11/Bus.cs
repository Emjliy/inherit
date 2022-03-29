using System;


namespace ConsoleApp11
{
    class Bus:Car
    {
        public int PassengerCount;
        public Bus(string Brand, string Model, string Colour, int MaxSpeed,int PassengerCount):base( Brand,  Model,  Colour,  MaxSpeed)
        {
            int Count;
        }
        public override void info()
        {
            Console.WriteLine($"Brand:{ Brand } ,Model{ Model }, Colour{ Colour}, MaxSpeed{ MaxSpeed } PassengerCount{PassengerCount}");
        }

    }
}
