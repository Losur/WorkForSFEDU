using System.Collections.Generic;

namespace Lab_2
{
    public class Pizza : PizzaMenuItem
    {
        public Pizza(string name, float cost)
        {
            Name = name;
            Cost = cost;
        }

        public override string GetCost()
        {
            return Name + " cost is " + Cost;
        }
    }
}