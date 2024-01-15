namespace DesignPatternDump.AbstractFactoryPattern
{
    internal abstract class PizzaStore
    {
        public Pizza OrderPizza(String type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        protected abstract Pizza CreatePizza(String type);
    }
}
