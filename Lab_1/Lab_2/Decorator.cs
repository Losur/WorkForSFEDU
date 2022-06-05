using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class Decorator : PizzaMenuItem
    {
        protected PizzaMenuItem _component;

        protected Decorator(PizzaMenuItem component)
        {
            _component = component;
        }

        public void SetComponent(PizzaMenuItem component)
        {
            this._component = component;
        }

        public override string GetCost()
        {
            if(this._component != null)
            {
                return this._component.GetCost();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}