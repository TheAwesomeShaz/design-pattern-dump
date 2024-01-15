namespace DesignPatternDump.AbstractFactoryPattern
{
    internal class CheesePizza : Pizza
    {
        private PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing Cheese Pizza");
            sliceStyle = ingredientFactory.CreateSliceStyle();  
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
        }
    }
}