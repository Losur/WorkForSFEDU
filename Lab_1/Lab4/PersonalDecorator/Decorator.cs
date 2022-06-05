using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Decorator : AbstractPlant
    {
        protected AbstractPlant _plant;
        protected AbstractNotifyingSystem _notifyingSystem;
        protected CustomLogger _customLogger = CustomLogger.Instance;

        public Decorator(AbstractNotifyingSystem notifyingSystem)
        {
            _notifyingSystem = notifyingSystem;
        }

        public void SetPlant(AbstractPlant component)
        {
            _plant = component;
        }

        public override void ChangeAirTemperature()
        {
            if(_plant != null)
            {
                _plant.ChangeAirTemperature();
            }
        }

        public override void DeletePlant()
        {
            if(_plant != null)
            {
                _plant.DeletePlant();
            }
        }

        public override void HealingPlant()
        {
            if(_plant != null)
            {
                _plant.ChangeAirTemperature();
            }
        }

        public override void RemoveLeaves()
        {
            if(_plant != null)
            {
                _plant.RemoveLeaves();
            }
        }

        public override void TrimPlant()
        {
            if(_plant != null)
            {
                _plant.TrimPlant();
            }
        }

        public override void ChangeSoilTemperature()
        {
            if(_plant != null)
            {
                _plant.ChangeAirTemperature();
            }
        }
    }
}