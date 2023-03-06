
using FactoryMethod.Creator;
using FactoryMethod.Simple_Factory;


Console.WriteLine("========= Pizzeria =========");
Console.WriteLine("Report the location (SP) São Paulo or (RJ) Rio de Janeiro");
var location = Console.ReadLine().ToUpper();

Console.WriteLine("Into English is Choose between (M) mozzarella or (C) calabrese pizza");
var chosenPizza = Console.ReadLine().ToUpper();

try
{
    PizzaFactoryMethod pizzeria = PizzaSimpleFactory.CreatePizzeria(location);

    var pizza = pizzeria.BuildPizza(chosenPizza);

    Console.WriteLine(pizza.Prepare());
    Console.WriteLine("Pizza successfully completed");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.ReadLine();

