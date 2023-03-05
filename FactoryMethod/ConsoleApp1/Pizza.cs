using System.Collections;
using System.Text;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected string Pasta;
        protected string Sauce;
        protected ArrayList Ingredients = new ArrayList();


        public string Prepare()
        {
            var sb = new StringBuilder();

            sb.Append($"preparing {Name} \n");
            sb.Append($"{Pasta} \n");
            sb.Append($"{Sauce} \n");
            sb.Append($"Ingredients: \n");

            foreach (string ingredient in Ingredients)
            {
                sb.Append($"\t {ingredient} \n");
            }

            sb.Append(Cook());
            sb.Append(Slice());
            sb.Append(Pack());

            return sb.ToString();
        }

        private string Pack()
        {
            return "Packing the pizza for the trip";
        }

        private string Slice()
        {
            return "Slicing the pizza into 8 pieces";
        }

        public virtual string Cook()
        {
            return "Cooking for 25 minutes and 350 degrees";
        }
    }
}
