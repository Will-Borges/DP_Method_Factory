using FactoryMethod.Product;

namespace FactoryMethod
{
    //ConcreteProduct
    public class PizzaMozzarellaRJ : Pizza
    {
        public PizzaMozzarellaRJ()
        {
            Name = "Mozzarella RJ";
            Pasta = "Thin and crust";
            Sauce = "Tomate Italian";
            Ingredients.Add("Parmesan cheese");
            Ingredients.Add("Green olives");
        }
    }
}
