using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace ExampleFactory
{
    /// <summary>
    /// Арбуз, является продукстом который нужно доставить 
    /// </summary>
    class Watermelon : IProduct
    {
        string _Name;

        public string Name
        {
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

}
