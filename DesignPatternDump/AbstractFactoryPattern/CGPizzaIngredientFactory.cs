namespace DesignPatternDump.AbstractFactoryPattern.Ingredients
{
    internal class CGPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese() => new MozarellaCheese();

        public Dough CreateDough() => new ThinCrustDough();

        public Sauce CreateSauce() => new TomatoSauce();

        public string CreateSliceStyle()
        {
            // This could also be an enum but eh this is just an example of a pattern dont think much about it
            return "Square";
        }
    }
}
