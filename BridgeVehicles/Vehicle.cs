using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeVehicles
{
    public abstract class Vehicle
    {
       protected IMotor _motor;
        public Vehicle(IMotor motor)
        {
            _motor = motor;
        }

        public abstract void runVehicle(string model);
    }
}
