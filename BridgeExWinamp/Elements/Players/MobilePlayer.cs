using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExWinamp.Elements.Players
{
    public class MobilePlayer : MusicPlayer
    {
        public MobilePlayer(IFormat format) : base(format)
        {
        }

        public override void Play(string filePath)
        {
            Console.WriteLine("Using Mobile Player");
            _format.Play(filePath);
        }
    }
}
