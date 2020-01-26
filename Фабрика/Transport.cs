using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace ExampleFactory
{
    /// <summary>
    /// Класс реализует машину как доставщика 
    /// </summary>
    public class Car : ITranport
    {
        /// <summary>
        /// Метод доставки 
        /// </summary>
        /// <param name="Product"> Какой-то продукт </param>
        public void Delivery(IProduct Product)
        {
            Console.WriteLine($"Доставка на машине {Product.Name}");
        }

        public TypeTrasport GetTypeTransport()
        {
            return TypeTrasport.Car;
        }
    }

    /// <summary>
    /// Класс реализует корабль как доставщика 
    /// </summary>
    public class Ship : ITranport
    {
        /// <summary>
        /// Метод доставки 
        /// </summary>
        /// <param name="Product"> Какой-то продукт </param>
        public void Delivery(IProduct Product)
        {
            Console.WriteLine($"Доставка на карабле {Product.Name}");
        }

        public TypeTrasport GetTypeTransport()
        {
            return TypeTrasport.Ship;
        }
    }
}
