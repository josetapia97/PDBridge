using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeVehicles.Elements.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(IMotor motor) : base(motor)
        {
        }

        public override void runVehicle(string model)
        {
            Console.WriteLine("Run the motorcycle");
            _motor.Run(model);
        }
    }
}
