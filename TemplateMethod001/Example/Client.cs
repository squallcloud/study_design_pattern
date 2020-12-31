using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod001.Example
{
    class Client
    {
        public void Execute()
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("\nMaking tea...");
            tea.prepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffee.prepareRecipe();
        }
    }
}
