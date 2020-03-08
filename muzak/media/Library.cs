using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace muzak.media
{
    /** The Library encompasses the full collection of Tracks as well as all generated Playlists */
    class Library
    {
        // Figure out how to reference this location properly.
        private static readonly string LIBRARY_LOCATION = "G:\\Code\\muzak\\library.sqlite";
        Playlist tracks;
        List<Playlist> playlists;

        void initialize()
        {
            if(!File.Exists(LIBRARY_LOCATION))
            {
                SQLiteConnection.CreateFile(LIBRARY_LOCATION);

            }
        }
    }
}
