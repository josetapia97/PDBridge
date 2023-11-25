using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExWinamp
{
    //define el comportamiento que debe tener cualquier reproductor independiente de la plataforma
    //define su abstraccion inyectando el formato pero sin implementarlo
    public abstract class MusicPlayer
    {
        protected IFormat _format;
        public MusicPlayer(IFormat format)
        {
            this._format = format;
        }

        public abstract void Play(string filePath);
    }
}
