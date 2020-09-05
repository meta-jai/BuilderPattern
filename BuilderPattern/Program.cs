using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaPepOlives = new PizzaBuilder(Size.Medium)
                         .AddSauce()
                         .AddCheese(Cheese.Provolone)
                         .AddPepperoni()
                         .AddOlives()
                         .Build();
        }
    }
}
