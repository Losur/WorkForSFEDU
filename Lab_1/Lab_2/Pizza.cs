namespace Lab_2
{
    public class Pizza : MenuItem
    {
        public Pizza() : base("Pizza", 14.76F)
        { }

        public override string GetCost()
        {
            return "Cost of Pizza is: " + Cost;
        }
    }
}