using System;

namespace Фабрика
{

        public enum TypeDost : int
        {
            DostCar,
            DostShip
        };
        public interface IProduct
        {
            TypeDost GetTypeTransport();

        }

        class arbus : IProduct
        {
            public TypeDost GetTypeTransport()
            {
                return TypeDost.DostCar;
            }
        }

        public interface IDost
        {
            public void Delyfari();
        }

        public class Car : IDost
        {
            public void Delyfari()
            {
                Console.WriteLine("Доставка на машине");
            }
        }

        public class Ship : IDost
        {
            public void Delyfari()
            {
                Console.WriteLine("Доставка на карабле");
            }
        }

        public class CreateDost
        {
            static public IDost CreateTransport(IProduct Product)
            {
                switch (Product.GetTypeTransport())
                {
                    case TypeDost.DostShip:
                        {
                            return new Ship();
                        }

                    case TypeDost.DostCar:
                        {
                            return new Car();
                        }
                    default:
                        return null;
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                arbus ar = new arbus();

                CreateDost.CreateTransport(ar);
            }
        }

}
