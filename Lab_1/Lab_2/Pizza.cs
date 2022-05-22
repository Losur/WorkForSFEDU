using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Pizza : MenuItem
    {
        public float cost = 14.76F;

        public Pizza() : base("Pizza")
        { }

        public override float GetCost()
        {
            return cost;
        }
    }
}