using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDump.FactoryPattern
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            return new NYStylePizza();
        }
    }
}
