namespace Lab_2
{
    public class IceCreamDecorator : Decorator
    {
        public IceCreamDecorator(PizzaMenuItem component) : base(component)
        {
            Name = "Ice Cream";
            Cost = 12.4F;
        }

        public override string GetCost()
        {
            return _component.Name + " cost with " + Name + " is " + (_component.Cost + Cost);
        }
    }
}