using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Car
    {
        public string Brand;
        public string Model;
        public string Colour;
        public int MaxSpeed;
        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string Brand, string Model)
        {
            Brand = Brand;
            Model = Model;

        }
        public Car(string Brand, string Model, string Colour, int MaxSpeed) : this(Brand, Model)
        {
            Colour = Colour;
            MaxSpeed = MaxSpeed;

        }
        public virtual void info()
        {
            Console.WriteLine($"Brand:{ Brand } ,Model{ Model }, Colour{ Colour}, MaxSpeed{ MaxSpeed }");
        }
    }
}
