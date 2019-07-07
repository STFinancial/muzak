package media;

import java.util.List;

/**
 * A single media file.
 */
public class Track {
    private final Media media;
    private final TrackMetadata metadata;
    private final TrackOptions options;

    Track(Media media, TrackMetadata metadata, TrackOptions options) {
        this.media = media;
        this.metadata = metadata;
        this.options = options;
    }
}
