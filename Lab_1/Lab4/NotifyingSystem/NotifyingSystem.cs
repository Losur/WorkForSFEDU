using System;

namespace Lab4
{
    public class NotifyingSystem : AbstractNotifyingSystem
    {
        private readonly CustomLogger _logger = CustomLogger.Instance;

        public override void Attach(Client client)
        {
            _logger.WriteInfo("\nNotifyingSystem: Attached an client - " + client.Name);
            _clients.Add(client);
        }

        public override void Detach(Client client)
        {
            _clients.Remove(client);
            _logger.WriteInfo("\nNotifyingSystem: Detached an client - " + client.Name);
        }

        public override void NotifyAboutinBadState(AbstractPlant plant)
        {
            _logger.WriteInfo("\nNotifying system: Notifying client  about plant health...\n");

            foreach(var client in _clients)
            {
                if(client.Id == plant.OwnerId)
                {
                    Program.WirteToConsoleWithColor($"You plant {plant.PlantType} is in a bad state\nWe trying to rescue it", ConsoleColor.Red);
                    break;
                }
            }
        }

        public override void NotifyAboutPlantDead(AbstractPlant plant)
        {
            _logger.WriteInfo("\nNotifying system: Notifying client about plant dead...\n");

            foreach(var client in _clients)
            {
                if(client.Id == plant.OwnerId)
                {
                    Program.WirteToConsoleWithColor($"We are so sorry but you plant {plant.PlantType} is dead(", ConsoleColor.Red);
                    break;
                }
            }
        }

        public override void NotifyAboutPlantWasDeleted(AbstractPlant plant)
        {
            _logger.WriteInfo("\nNotifying system: Notifying client...\n");

            foreach(var client in _clients)
            {
                if(client.Id == plant.OwnerId)
                {
                    Program.WirteToConsoleWithColor($"Plant was deleted successful. RIP little {plant.PlantType}", ConsoleColor.Cyan);
                    break;
                }
            }
        }
    }
}