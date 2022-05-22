using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class IceCream : MenuItem
    {
        public float cost = 9.4F;

        public IceCream() : base("Ice Cream")
        { }

        public override float GetCost()
        {
            return cost;
        }
    }
}