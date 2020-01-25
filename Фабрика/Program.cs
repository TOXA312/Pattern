using System;

namespace ExampleFactory
{

    /// <summary>
    /// Интерфейс который задает основные хар-ки продукта 
    /// </summary>
    public interface IProduct
    {
       string Name { get; set; }
    }

    /// <summary>
    /// Арбус, является продукстом который нужно доставить 
    /// </summary>
    class Watermelon : IProduct
    {
        string _Name;

        public string Name { 
            get => _Name; 
            set => _Name = value; 
        }
        /// <summary>
        /// Создает объект арбуз
        /// </summary>
        /// <param name="NameProduct">Имя арбуза </param>
        public Watermelon(string NameProduct)
        {
            _Name = NameProduct;
        }

    }
    /// <summary>
    /// Интерфейс описывающий транспорт 
    /// </summary>
    public interface ITranport
    {
        /// <summary>
        /// Метод доставки продукта в точку назначений(точка абстрактная, как и пррдукт )
        /// </summary>
        /// <param name="Product"> Какой-то продукт для доставки </param>
        public void Delivery(IProduct Product);
    }

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
    }

    class Program
    {
        static void Main(string[] args)
        {
            IProduct Product = new Watermelon("Арбуз");

            Car CarDelivery = new Car();

            CarDelivery.Delivery(Product);

            Ship ShipDelivery = new Ship();

            ShipDelivery.Delivery(Product);
        }
    }
}
