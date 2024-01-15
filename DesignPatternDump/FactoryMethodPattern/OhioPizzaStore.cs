using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDump.FactoryPattern
{
    internal class OhioPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            return new OhioStylePizza();
        }
    }
}
