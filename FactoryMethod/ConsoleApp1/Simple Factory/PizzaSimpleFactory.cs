using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;

namespace FactoryMethod.Simple_Factory
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CreatePizzeria(string location)
        {
            switch (location)
            {
                case "SP":
                    return new PizzaFactorySP();

                case "RJ":
                    return new PizzaFactoryRJ();

                default:
                    throw new ApplicationException($"The location {location}, not is valid");
            }
        }
    }
}
