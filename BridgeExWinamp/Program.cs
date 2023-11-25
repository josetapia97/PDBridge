using BridgeExWinamp;
using BridgeExWinamp.Elements.Players;
using BridgeExWinamp.NewFolder.Formats;

/*crear 3 casos de uso
 * 1. Desktop mp3.
 * 2. Mobile WAV
 * 3. Desktop WAV
*/

IFormat mp3format = new MP3();
MusicPlayer dskt = new DesktopPlayer(mp3format);
dskt.Play("path:user/music/despacito.mp3");

IFormat wav = new WAV();
MusicPlayer mob = new MobilePlayer(wav);
mob.Play("path:Android/src/music/nostalgIA.wav");

dskt = new DesktopPlayer(wav);
dskt.Play("path:user/music/KanyeWest.mp3");
