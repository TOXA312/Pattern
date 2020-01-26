using System;
using Model;

namespace ExampleFactory
{
 
    class Program
    {
        static void Main(string[] args)
        {
            IProduct Product = new Watermelon("Арбуз - квадратный");

            CreatrCar car = new CreatrCar();

            ITranport Tranport = car.CreatTransport();

            Tranport.Delivery(Product);

            CreateShip ship = new CreateShip();

            Tranport = ship.CreatTransport();

            Tranport.Delivery(Product);

            /*Car CarDelivery = new Car();

            CarDelivery.Delivery(Product);

            Ship ShipDelivery = new Ship();

            ShipDelivery.Delivery(Product);*/
        }
    }
}
