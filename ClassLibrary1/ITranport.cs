using System;

namespace Model
{
    /// <summary>
    /// Типы транспортов которые поддерживаются в данный момент системой
    /// </summary>
    public enum TypeTrasport: int
    { 
        Car,
        Ship
    };
    
    /// <summary>
    /// Интерфейс описывающий транспорт 
    /// </summary>
    public interface ITranport
    {

        /// <summary>
        /// Метод возвращает тип транспорта 
        /// </summary>
        /// <returns>Тип транспорта </returns>
        TypeTrasport GetTypeTransport();
        
        /// <summary>
        /// Метод доставки продукта в точку назначений(точка абстрактная, как и пррдукт )
        /// </summary>
        /// <param name="Product"> Какой-то продукт для доставки </param>
        void Delivery(IProduct Product);
    }
}
