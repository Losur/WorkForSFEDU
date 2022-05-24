namespace Lab_2
{
    public class IceCream : MenuItem
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