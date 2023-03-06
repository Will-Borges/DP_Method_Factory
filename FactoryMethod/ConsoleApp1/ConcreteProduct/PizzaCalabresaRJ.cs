using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    //ConcreteProduct
    public class PizzaCalabreseRJ : Pizza
    {
        public PizzaCalabreseRJ()
        {
            Name = "Calabrese RJ";
            Pasta = "Thin and crust";
            Sauce = "Tomate Italian";
            Ingredients.Add("Minas cheese");
            Ingredients.Add("Oregano");
        }
    }
}
