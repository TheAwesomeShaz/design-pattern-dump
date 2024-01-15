using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDump.AbstractFactoryPattern.Ingredients;

namespace DesignPatternDump.AbstractFactoryPattern
{
    internal interface PizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public string CreateSliceStyle();
    }
}
