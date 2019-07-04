package media;

import java.util.List;

/**
 * A single media file.
 */
public class Track {
    private final Media media;
    private final TrackMetadata metadata;

    Track(Media media, TrackMetadata metadata) {
        this.media = media;
        this.metadata = metadata;
    }
}
