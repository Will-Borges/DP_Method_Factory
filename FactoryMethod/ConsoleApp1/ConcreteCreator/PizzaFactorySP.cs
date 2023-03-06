using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    //ConcreteCreator
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "M":
                    return new PizzaMozzarellaSP();

                case "C":
                    return new PizzaCalabreseSP();

                default:
                    return null;
            }
        }
    }
}
