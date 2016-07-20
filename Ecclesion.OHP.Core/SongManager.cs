using Ecclesion.OHP.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesion.OHP.Core
{
    public static class SongManager
    {
        private static List<Song> LastSuggestions { get; set; }

        private static List<Song> _knownSongs;
        private static List<Song> KnownSongs
        {
            get
            {
                if (_knownSongs == null)
                {
                    _knownSongs = LoadSongs();
                }
                return _knownSongs;
            }
        }

        public static void EagerLoad()
        {
            _knownSongs = LoadSongs();
        }

        public static List<string> FailedFiles { get; set; }

        private static List<Song> LoadSongs()
        {
            FailedFiles = new List<string>();
            var songs = new List<Song>();

            if (Directory.Exists(FileCore.SONGS))
            {
                foreach(var file in Directory.GetFiles(FileCore.SONGS))
                {
                    try
                    {
                        var content = File.ReadAllText(file);
                        var song = JsonConvert.DeserializeObject<Song>(content);
                        songs.Add(song);
                    }
                    catch (Exception ex)
                    {
                        FailedFiles.Add(String.Format("{0}: {1}", file, ex.Message));
                    }
                }
            }

            return songs;
        }

        public static void SaveSong(Song song)
        {
            if (Directory.Exists(FileCore.SONGS))
            {
                var songJson = JsonConvert.SerializeObject(song);
                var filePath = FileCore.GetPath(FileCore.SONGS, song.UID);
                File.WriteAllText(filePath, songJson);
            }
        }

        public static List<Song> FindMatches(string input)
        {
            LastSuggestions = KnownSongs
                .Where(s => IsMatch(input, s.ToString()))
                .OrderBy(s => s.Hash)
                .ToList();

            return LastSuggestions;
        }

        public static bool IsMatch(string input, string songString)
        {
            return songString.ToLower().Contains(input.ToLower());
        }

        public static Song SelectedMatch(int selectedId)
        {
            return LastSuggestions[selectedId];
        }

    }
}
