using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExWinamp.NewFolder.Formats
{
    public class WAV : IFormat
    {
        public void Play(string filepath)
        {
            Console.WriteLine($"Playing WAV file {filepath}");
        }
    }
}
