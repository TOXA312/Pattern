using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace ExampleFactory
{
    class CreateShip : ICreator
    {
        public ITranport CreatTransport()
        {
            return new Ship();
        }
    }
}
