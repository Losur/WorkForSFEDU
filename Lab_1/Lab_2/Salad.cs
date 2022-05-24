using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Salad : MenuItem
    {
        private float cost = 12.4F;

        public Salad() : base("Salad")
        { }

        public override float GetCost()
        {
            return cost;
        }
    }
}