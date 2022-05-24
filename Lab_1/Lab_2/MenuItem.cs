namespace Lab_2
{
    public abstract class MenuItem
    {
        protected MenuItem(string n) => this.Name = n;

        public string Name { get; protected set; }

        public abstract float GetCost();
    }
}