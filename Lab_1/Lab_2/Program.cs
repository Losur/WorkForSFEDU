using System;
using System.Collections;
using System.Diagnostics;

namespace Lab_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for(var j = 0; j < 3; j++)
            {
                var menuItems = new ArrayList();
                for(var i = 0; i < 3; i++)
                {
                    Random random = new Random();
                    var type = random.Next(0, 3);
                    MenuItem menuItem;
                    switch(type)
                    {
                        case 0:
                            menuItem = new Pizza();
                            menuItems.Add(menuItem);
                            break;

                        case 1:
                            menuItem = new Salad();
                            menuItems.Add(menuItem);
                            break;

                        case 2:
                            menuItem = new IceCream();
                            menuItems.Add(menuItem);
                            break;
                    }
                }

                float sum = 0;
                foreach(MenuItem item in menuItems)
                {
                    sum += item.GetCost();
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("\n" + sum + "\n\n");
            }
        }
    }
}