using System;

namespace Lab_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pizza pizza = new Pizza("Italian pizza", 7F);
            pizza.Cost = 15.0F;
            Console.WriteLine(pizza.GetCost());
            Console.WriteLine("");

            SaladDecorator sd = new SaladDecorator(pizza);
            IceCreamDecorator ic = new IceCreamDecorator(pizza);

            Console.WriteLine(sd.GetCost());
            Console.WriteLine("");
            Console.WriteLine(ic.GetCost());
            Console.WriteLine("");
            IceCreamDecorator icTest = new IceCreamDecorator(sd);
            Console.WriteLine(icTest.GetCost());
        }
    }
}