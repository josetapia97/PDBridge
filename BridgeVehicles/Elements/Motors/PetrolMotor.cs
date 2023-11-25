using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeVehicles.Elements.Motors
{
    public class PetrolMotor : IMotor
    {
        public void Run(string runMessage)
        {
            Console.WriteLine($"the oil is being burned in {runMessage}");
        }
    }
}
