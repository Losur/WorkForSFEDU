using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Client
    {
        public Client(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public void AskAboutPlant()
        {
            Console.WriteLine(Name + " asked: What's going on with my plant?");
        }

        public void GetResponce(AbstractPlant plant)
        {
            if(plant.Health == Health.Die)
            {
                Program.WirteToConsoleWithColor("We are so sorry, but your plant is dead", ConsoleColor.DarkRed);
                return;
            }
            Program.WirteToConsoleWithColor("Plant: " + plant.PlantType, ConsoleColor.Green);
            if(plant.Health == Health.Good)
            {
                Program.WirteToConsoleWithColor("Health: " + plant.Health, ConsoleColor.Green);
            }
            else
            {
                Program.WirteToConsoleWithColor("Health: " + plant.Health, ConsoleColor.Yellow);
            }

            if(plant.AirTemperature < plant.NormalAirTemperature - 10 || plant.AirTemperature > plant.NormalAirTemperature + 20)
            {
                Program.WirteToConsoleWithColor("Air temperature is: " + plant.AirTemperature, ConsoleColor.Yellow);
            }
            else
            {
                Program.WirteToConsoleWithColor("Air temperature is: " + plant.AirTemperature, ConsoleColor.Green);
            }

            if(plant.SoilTemperature < plant.NormalSoilTemperature - 10 || plant.SoilTemperature > plant.NormalSoilTemperature + 20)
            {
                Program.WirteToConsoleWithColor("Soil temperature is: " + plant.SoilTemperature, ConsoleColor.Yellow);
            }
            else
            {
                Program.WirteToConsoleWithColor("Soil temperature is: " + plant.SoilTemperature, ConsoleColor.Green);
            }

            if(plant.IsRemoveLeaves)
            {
                Program.WirteToConsoleWithColor("Leaves are not removed ", ConsoleColor.Yellow);
            }
            else
            {
                Program.WirteToConsoleWithColor("Leaves are removed ", ConsoleColor.Green);
            }
            if(plant.IsTrimNeeded)
            {
                Program.WirteToConsoleWithColor("Trim is needed", ConsoleColor.Yellow);
            }
            else
            {
                Program.WirteToConsoleWithColor("Trim is ok", ConsoleColor.Green);
            }

            Console.WriteLine();
        }
    }
}