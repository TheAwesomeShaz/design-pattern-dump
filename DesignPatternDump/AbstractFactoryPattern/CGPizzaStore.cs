using DesignPatternDump.AbstractFactoryPattern.Ingredients;

namespace DesignPatternDump.AbstractFactoryPattern
{
    internal class CGPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new CGPizzaIngredientFactory();

            if (type == "Cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("CGCheesePizza");
            }
            else if (type == "Veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("CGVeggiePizza");
            }
            return pizza;
        }
    }
}
