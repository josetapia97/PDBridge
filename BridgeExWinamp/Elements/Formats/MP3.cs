using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExWinamp.NewFolder.Formats
{
    public class MP3 : IFormat
    {
        public void Play(string filepath)
        {
            Console.WriteLine($"Playing MP3 file {filepath}");
        }
    }
}
