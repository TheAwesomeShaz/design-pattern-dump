using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDump.AbstractFactoryPattern.Ingredients;

namespace DesignPatternDump.AbstractFactoryPattern
{
    internal abstract class Pizza
    {
        String name;
        protected string sliceStyle;
        protected Dough dough;
        protected Sauce sauce;
        protected Cheese cheese;

        internal abstract void Prepare();
        internal void Bake()
        {
            Console.WriteLine("Baking the Pizza");
        }
        internal void Cut()
        {
            Console.WriteLine("Cutting the Pizza in "+sliceStyle+" slices");
        }
        internal void Box()
        {
            Console.WriteLine("Pizza goes into da box");
        }
        internal void SetName(String name)
        {
            this.name = name;
        }
        internal string GetName()
        {
            return name;
        }

    }
}
