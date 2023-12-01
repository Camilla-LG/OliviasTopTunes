using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliviasTopTunes
{
    internal class Songs
    {
        public string Band { get; set; }
        public string Song { get; set; }
      

        
        public void SongInfo(string band, string song)
        {
            Band = band;
            Song = song;
        }

        public AddSongs(string band, string song)
        {
            var ListOfSongs = new List<SongInfo>();
        }

        public void DisplaySongInfo(string band, string song)
        {
            for (var i = 0; i < Band.Length; i++) { }
            {
                Console.WriteLine($"{song} av {band}");
            }
        }
    }
}
