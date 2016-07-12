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
        public static void SaveSong(Song song)
        {
            if (Directory.Exists(FileCore.SONGS))
            {
                var songJson = JsonConvert.SerializeObject(song);
                var filePath = FileCore.GetPath(FileCore.SONGS, song.UID);
                File.WriteAllText(filePath, songJson);
            }
        }
    }
}
