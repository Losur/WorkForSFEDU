using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Plant : AbstractPlant
    {
        private readonly CustomLogger _logger = CustomLogger.Instance;

        public Plant(int ownerId, string name, Health health, float airTemperature, float soilTemperature)
        {
            OwnerId = ownerId;
            PlantType = name;
            Health = health;
            NormalAirTemperature = airTemperature;
            NormalSoilTemperature = soilTemperature;
            AirTemperature = (float)(new Random().NextDouble() * 100);
            SoilTemperature = (float)(new Random().NextDouble() * 100);
            IsTrimNeeded = new Random().Next(0, 2) == 1;
            IsRemoveLeaves = new Random().Next(0, 2) == 1;
        }

        public override void ChangeAirTemperature()
        {
            _logger.WriteInfo("It's just a plant. His air temperature" + AirTemperature);
        }

        public override void ChangeSoilTemperature()
        {
            _logger.WriteInfo("It's just a plant. His soil temperature" + SoilTemperature);
        }

        public override void DeletePlant()
        {
            _logger.WriteInfo("It's just a plant and it not should be deleted(");
        }

        public override void HealingPlant()
        {
            _logger.WriteInfo("It's just a plant. And his in " + Health + " health");
        }

        public override void RemoveLeaves()
        {
            _logger.WriteInfo("It's just a plant. Is he has useless leaves? " + IsRemoveLeaves);
        }

        public override void TrimPlant()
        {
            _logger.WriteInfo("It's just a plant. Is he need to be trimmed? " + IsTrimNeeded);
        }
    }
}