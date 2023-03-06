using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    //ConcreteCreator
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "M":
                    return new PizzaMozzarellaRJ();

                case "C":
                    return new PizzaCalabreseRJ();

                default:
                    return null;
            }
        }
    }
}
