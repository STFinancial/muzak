package media;

import java.util.List;

/**
 * Music player independent metadata about a particular track.
 */
public class TrackMetadata {
    private String trackName;
    private String albumArtist;
    private List<String> contributingArtists;
    private String albumName;
    private String recordLabel;
    private String releaseDate;
    private String releaseYear;
    /** Length of the {@link media.Track Trade}, in milliseconds. */
    private int songLength;

    /** This should contain high level genres, like Rock or Jazz */
    private List<String> genres;
    /** This should contain more granular genres, like Noise Rock or Hard Bop */
    private List<String> subGenres;
    /** These can be any sort of user generated tags, such as "Party", "Normie", "Top40" to allow the user to filter on these criteria. */
    private List<String> tags;
    /** These are song descriptors akin to RYM descriptors. Should directly describe the music, e.g. lush, noisy, rhythmic, solemn, etc. */
    private List<String> descriptors;

    //****** STATS METADATA ******//
    private int finishedCount;
    private int startedCount;
    private int totalPlayTime;
    private int skipCount; // ?
    private boolean starred;
    private float trackRating; // Probably from 0-5
}
