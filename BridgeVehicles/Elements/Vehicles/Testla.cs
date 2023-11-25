using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeVehicles.Elements.Vehicles
{
    public class Testla : Vehicle
    {
        public Testla(IMotor motor) : base(motor)
        {
        }

        public override void runVehicle(string model)
        {
            Console.WriteLine("Run the Tesla");
            _motor.Run(model);
        }
    }
}
