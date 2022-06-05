namespace Lab4
{
    public abstract class AbstractPlant
    {
        public int OwnerId { get; set; }
        public float NormalAirTemperature { get; protected set; }
        public float NormalSoilTemperature { get; protected set; }
        public float AirTemperature { get; set; }
        public float SoilTemperature { get; set; }
        public string PlantType { get; set; }
        public Health Health { get; set; }
        public bool IsRemoveLeaves { get; set; }
        public bool IsTrimNeeded { get; set; }

        public abstract void HealingPlant();

        public abstract void DeletePlant();

        public abstract void TrimPlant();

        public abstract void ChangeAirTemperature();

        public abstract void ChangeSoilTemperature();

        public abstract void RemoveLeaves();
    }
}