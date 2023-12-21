using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDump.FactoryPattern
{
    internal class OhioStylePizza : Pizza
    {
        public OhioStylePizza()
        {
            name = "Ohio Style Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Mozzarella Cheese");
        }

        void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices cuz we from Ohio");
        }
    }
}
