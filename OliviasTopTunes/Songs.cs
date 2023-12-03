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
        string DoublecheckSong = "";

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
        public void DeleteSong()
        {
            DisplaySongInfo();
            Console.WriteLine();
            Console.WriteLine("Hvilken av disse sangene vil du slette? Skriv inn navnet på sangen.");
            var songToDelete = Console.ReadLine();

            var songToRemove = ListOfSongs.FirstOrDefault(s => s.Song.Equals(songToDelete, StringComparison.OrdinalIgnoreCase));

            if (songToRemove != null)
            {
                Console.WriteLine($"Vil du slette {songToRemove.Song} av {songToRemove.Band}? J/N");
                var doubleCheckSong = Console.ReadLine();

                if (doubleCheckSong.ToLower() == "j")
                {
                    ListOfSongs.Remove(songToRemove);
                    Console.WriteLine($"{songToRemove.Song} av {songToRemove.Band} er nå fjernet fra listen.");
                }
                else
                {
                    Console.WriteLine("Sletting avbrutt.");
                }
            }
            else
            {
                Console.WriteLine("Finner ikke sangen i listen.");
            }
        }
    }
}

