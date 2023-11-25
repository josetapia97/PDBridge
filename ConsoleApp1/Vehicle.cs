using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrindeVehicleV2
{
    public abstract class Vehicle
    {
        protected IEngine _engine;

        public Vehicle(IEngine engine)
        {
            _engine = engine;
        }

        public abstract void Drive();
    }
}
