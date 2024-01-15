namespace DesignPatternDump.AbstractFactoryPattern
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if(type == "Cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("NYCheesePizza");  
            }
            else if(type == "Veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("NYVeggiePizza");  
            }
            return pizza;
        }
    }
}
