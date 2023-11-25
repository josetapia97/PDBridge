using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrindeVehicleV2.Elements.Engine
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting electric engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping electric engine");
        }
    }
}
