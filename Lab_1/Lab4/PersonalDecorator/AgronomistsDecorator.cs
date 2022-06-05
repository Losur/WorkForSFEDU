using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class AgronomistsDecorator : Decorator
    {
        public AgronomistsDecorator(AbstractNotifyingSystem notifyingSystem) : base(notifyingSystem)
        {
        }

        public override void ChangeAirTemperature()
        {
            var healthValue = new Random().Next(0, 3);
            _customLogger.WriteInfo("Agronomist change the Air temperature...");
            System.Threading.Thread.Sleep(300);

            _plant.AirTemperature = (float)new Random().NextDouble() * 100;

            Health health;
            switch(healthValue)
            {
                case 0:
                    health = Health.Good;
                    break;

                case 1:
                    health = Health.Bad;
                    break;

                default:
                    health = Health.Die;
                    break;
            }
            _plant.Health = health;

            if(_plant.Health == Health.Die)
            {
                _customLogger.WriteInfo($"Plant ({_plant.PlantType}) was killed by Agronomists");
                Program.WirteToConsoleWithColor("Plant was killed by the air temperature", ConsoleColor.DarkRed);
            }
        }

        public override void ChangeSoilTemperature()
        {
            var healthValue = new Random().Next(0, 3);
            _customLogger.WriteInfo("Agronomist change the soil temperature...");
            System.Threading.Thread.Sleep(300);
            _plant.AirTemperature = (float)new Random().NextDouble() * 100;

            Health health;
            switch(healthValue)
            {
                case 0:
                    health = Health.Good;
                    break;

                case 1:
                    health = Health.Bad;
                    break;

                default:
                    health = Health.Die;
                    break;
            }

            _plant.Health = health;

            if(health == Health.Die)
            {
                _customLogger.WriteInfo($"Plant ({_plant.PlantType}) was killed by Agronomists");
                _notifyingSystem.NotifyAboutPlantDead(_plant);
            }
        }

        public override void DeletePlant()
        {
            _customLogger.WriteInfo("Agronomist is deleting plant...");
            System.Threading.Thread.Sleep(500);
            _notifyingSystem.NotifyAboutPlantWasDeleted(_plant);
            _customLogger.WriteInfo($"Plant ({_plant.PlantType}) was deleted by Agronomists");
        }

        public override void HealingPlant()
        {
            _customLogger.WriteInfo("Agronomist try to healing plant...");
            System.Threading.Thread.Sleep(1500);
            if(new Random().Next(0, 2) == 0)
            {
                _plant.Health = Health.Die;
                Program.WirteToConsoleWithColor("Plant is dead", ConsoleColor.DarkRed);
                _notifyingSystem.NotifyAboutPlantDead(_plant);
            }
            else
            {
                _plant.Health = Health.Good;
                Program.WirteToConsoleWithColor("Plant is hilled", ConsoleColor.Green);
            }
        }

        public override void RemoveLeaves()
        {
            if(!_plant.IsRemoveLeaves)
            {
                _customLogger.WriteInfo("Do not needed to remove leaves");
                _plant.IsRemoveLeaves = new Random().Next(0, 2) == 1;
            }
            else
            {
                _customLogger.WriteInfo("Agronomist is helping to remove leaves...");
                System.Threading.Thread.Sleep(300);
                _plant.IsRemoveLeaves = new Random().Next(0, 2) == 1;
            }
        }

        public override void TrimPlant()
        {
            if(!_plant.IsTrimNeeded)
            {
                _customLogger.WriteInfo("Do not needed to trim");
                _plant.IsTrimNeeded = new Random().Next(0, 2) == 1;
            }
            else
            {
                _customLogger.WriteInfo("Agronomist is trimming plant...");
                System.Threading.Thread.Sleep(300);
                _plant.IsTrimNeeded = new Random().Next(0, 2) == 1;
            }
        }
    }
}