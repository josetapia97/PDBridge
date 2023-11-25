﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExWinamp.Elements.Players
{
    public class DesktopPlayer : MusicPlayer
    {
        public DesktopPlayer(IFormat format) : base(format)
        {
        }

        public override void Play(string filePath)
        {
            Console.WriteLine("Using Desktop Player");
            _format.Play(filePath);
        }
    }
}
