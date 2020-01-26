using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// Интерфейс который задает основные хар-ки продукта 
    /// </summary>
    public interface IProduct
    {
        string Name { get; set; }
    }
}
