using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatternDump.FactoryPattern
{
    internal class NYStylePizza : Pizza
    {
        public NYStylePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
