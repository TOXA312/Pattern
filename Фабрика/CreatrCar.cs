using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace ExampleFactory
{
    class CreatrCar : ICreator
    {
        public ITranport CreatTransport()
        {
            return new Car();
        }
    }
}
