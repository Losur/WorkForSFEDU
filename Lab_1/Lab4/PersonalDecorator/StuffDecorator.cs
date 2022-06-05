using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class StuffDecorator : Decorator
    {
        public StuffDecorator(AbstractNotifyingSystem notifyingSystem) : base(notifyingSystem)
        {
        }

        public override void ChangeAirTemperature()
        {
            _customLogger.WriteInfo("Stuff cannot change air temperature. Skip");
            _customLogger.WriteInfo("Stuff check temperature...");
            System.Threading.Thread.Sleep(300);
            _plant.AirTemperature = (float)new Random().NextDouble() * 100;
        }

        public override void ChangeSoilTemperature()
        {
            _customLogger.WriteInfo("Stuff cannot change soil temperature. Skip");
            _customLogger.WriteInfo("Stuff check temperature...");
            System.Threading.Thread.Sleep(300);
            _plant.SoilTemperature = (float)new Random().NextDouble() * 100;
        }

        public override void DeletePlant()
        {
            _customLogger.WriteInfo("Stuff is checking plant...");
            System.Threading.Thread.Sleep(300);
            _plant.Health = new Random().Next(0, 1) == 0 ? Health.Good : Health.Die;
            if(_plant.Health == Health.Die)
            {
                _customLogger.WriteInfo($"Plant ({_plant.PlantType}) was killed by Stuff");
                Program.WirteToConsoleWithColor("Plant is dead", ConsoleColor.DarkRed);
            }
        }

        public override void HealingPlant()
        {
            _customLogger.WriteInfo("Stuff try to healing plant...");
            System.Threading.Thread.Sleep(300);
            if(new Random().Next(0, 1) == 0)
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
            }
            else
            {
                _customLogger.WriteInfo("Stuff is removing leaves...");
                System.Threading.Thread.Sleep(300);
                _plant.IsRemoveLeaves = new Random().Next(0, 1) == 1;
            }
        }

        public override void TrimPlant()
        {
            _customLogger.WriteInfo("Stuff cannot trim plant. Skip");
        }
    }
}