using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliviasTopTunes
{
    internal class Songs
    {
        private List<Songs> ListOfSongs = new List<Songs>();

        public string Band { get; set; }
        public string Song { get; set; }

        public Songs(string band, string song)
        {
            Band = band;
            Song = song;
        }

        public void AddSong(string band, string song)
        {
            ListOfSongs.Add(new Songs(band, song));
            Console.WriteLine("Sangen er lagt til.");
            Console.WriteLine();
        }

        public void DisplaySongInfo()
        {
            foreach (var song in ListOfSongs)
            {
                Console.WriteLine($"    *   {song.Song} av {song.Band}");
            }
            Console.WriteLine();
        }
    }
}
