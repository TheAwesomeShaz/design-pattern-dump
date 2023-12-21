namespace DesignPatternDump.FactoryPattern
{
    internal abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new();


        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough..");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(" " + toppings[i]);
            }
        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string GetName()
        {
            return name;
        }
    }
}
