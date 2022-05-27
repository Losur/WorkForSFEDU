namespace Lab_2
{
    public abstract class MenuItem
    {
        protected MenuItem(string n, float cost)
        {
            this.Cost = cost;
            this.Name = n;
        }

        public float Cost { get; protected set; }
        public string Name { get; protected set; }

        public abstract string GetCost();
    }
}