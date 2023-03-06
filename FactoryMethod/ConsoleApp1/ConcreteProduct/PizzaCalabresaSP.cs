using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    //ConcreteProduct
    public class PizzaCalabreseSP : Pizza
    {
        public PizzaCalabreseSP()
        {
            Name = "Calabrese SP";
            Pasta = "Thin and crust";
            Sauce = "Tomate Italian";
            Ingredients.Add("Minas cheese");
            Ingredients.Add("Oregano");
        }
    }
}
