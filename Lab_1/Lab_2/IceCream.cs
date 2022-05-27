namespace Lab_2
{
    public class IceCream : MenuItem
    {
        public IceCream() : base("Ice Cream", 9.4F)
        { }

        public override string GetCost()
        {
            return "IceCream could cost: " + Cost;
        }
    }
}