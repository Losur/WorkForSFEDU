namespace Lab_2
{
    public class Salad : MenuItem
    {
        public Salad() : base("Salad", 12.4F)
        { }

        public override string GetCost()
        {
            return "Salad cost is: " + Cost;
        }
    }
}