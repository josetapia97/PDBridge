using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeVehicles
{
    public interface IMotor
    {
        public void Run(string runMessage);
    }
}
