using FactoryMethod.Product;

namespace FactoryMethod
{
    //ConcreteProduct
    public class PizzaMozzarellaSP : Pizza
    {
        public PizzaMozzarellaSP()
        {
            Name = "Mozzarella SP";
            Pasta = "Thin and crust";
            Sauce = "Tomate Italian";
            Ingredients.Add("Parmesan cheese");
            Ingredients.Add("Green olives");
        }
    }
}
