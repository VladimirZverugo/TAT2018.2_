using System;
using System.Collections.Generic;
using DEV5_car_base;

namespace DEV5_car_base
{
    public class CarData
    {
        public int amount = 0;
        public string brand = "";
        public string model = "";
        public int stock = 0;
        public double price = 0;

        public void inPut(){

            Console.WriteLine("Brand");
            this.brand = Console.ReadLine();

            Console.WriteLine("Model");
            this.model = Console.ReadLine();

            Console.WriteLine("Stock");
            this.stock = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price");
            this.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=================");

        }
    }
}
