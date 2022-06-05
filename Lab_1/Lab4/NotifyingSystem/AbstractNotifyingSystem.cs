using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class AbstractNotifyingSystem
    {
        protected readonly List<Client> _clients = new List<Client>();

        public abstract void Attach(Client client);

        public abstract void Detach(Client client);

        public abstract void NotifyAboutPlantDead(AbstractPlant plant);

        public abstract void NotifyAboutinBadState(AbstractPlant plant);

        public abstract void NotifyAboutPlantWasDeleted(AbstractPlant plant);
    }
}