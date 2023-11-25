using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrindeVehicleV2.Elements.Engine
{
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting petrol engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping petrol engine");
        }
    }
}
