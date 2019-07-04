package media;

import java.util.List;

/**
 * Created by Timothy on 7/3/19.
 */
public class TrackMetadata {
    private String trackName;
    private String albumArtist;
    private List<String> contributingArtists;
    private List<String> genres;
    private List<String> subGenres;
    /** Length of the {@link media.Track Trade}, in milliseconds. */
    private int songLength;

    private String albumName;
    private String recordLabel;
    private String releaseDate;
    private String releaseYear;
}
