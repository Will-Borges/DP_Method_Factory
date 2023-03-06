using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    //Creator
    public abstract class PizzaFactoryMethod
    {
        public Pizza BuildPizza(string type)
        {
            return CreatePizza(type);
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
