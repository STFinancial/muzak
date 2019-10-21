using System.Collections.Generic;

namespace muzak.media
{
    /** Music player independent metadata bout a particular track. */
    class TrackMetadata
    {
        private string trackName;
        private string albumArtist;
        private List<string> contributingArtists;
        private string albumName;
        private string recordLabel;
        private string releaseDate;
        private string releaseYear;
        /** Length of the {@link media.Track Trade}, in milliseconds. */
        private int songLength;

        /** This should contain high level genres, like Rock or Jazz */
        private List<string> genres;
        /** This should contain more granular genres, like Noise Rock or Hard Bop */
        private List<string> subGenres;
        /** These can be any sort of user generated tags, such as "Party", "Normie", "Top40" to allow the user to filter on these criteria. */
        private List<string> tags;
        /** These are song descriptors akin to RYM descriptors. Should directly describe the music, e.g. lush, noisy, rhythmic, solemn, etc. */
        private List<string> descriptors;

        //****** STATS METADATA ******//
        private int finishedCount;
        private int startedCount;
        private int totalPlayTime;
        private int skipCount; // ?
        private bool starred;
        private float trackRating; // Probably from 0-5
    }
}
