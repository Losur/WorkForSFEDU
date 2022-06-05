using System;

namespace Lab_2
{
    public abstract class PizzaMenuItem
    {
        public float Cost { get; set; }
        public string Name { get; set; }

        public abstract string GetCost();
    }
}