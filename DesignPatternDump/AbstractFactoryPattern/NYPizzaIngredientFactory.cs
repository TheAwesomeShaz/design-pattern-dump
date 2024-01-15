using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDump.AbstractFactoryPattern.Ingredients;

namespace DesignPatternDump.AbstractFactoryPattern
{
    internal class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese() => new ReggianoCheese();

        public Dough CreateDough() => new ThickCrustDough();

        public Sauce CreateSauce() => new MarinaraSauce();

        public string CreateSliceStyle()
        {
            // This could also be an enum but eh this is just an example of a pattern dont think much about it
            return "Diagonal";
        }
    }
}
