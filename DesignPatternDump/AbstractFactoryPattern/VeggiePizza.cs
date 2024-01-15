namespace DesignPatternDump.AbstractFactoryPattern
{
    internal class VeggiePizza : Pizza
    {
        private PizzaIngredientFactory ingredientFactory;

        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing Veggie Pizza");
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            sliceStyle = ingredientFactory.CreateSliceStyle();
        }
    }
}