namespace Lab_2
{
    public class SaladDecorator : Decorator
    {
        public SaladDecorator(PizzaMenuItem component) : base(component)
        {
            Name = "Salad";
            Cost = 6.4F;
        }

        public override string GetCost()
        {
            return _component.Name + " cost with " + Name + " is " + (_component.Cost + Cost);
        }
    }
}