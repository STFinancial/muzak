package media;

/**
 * Created by Timothy on 7/3/19.
 */
public class Media {
    // TODO(stfinancial): Does this class also represent album artworks?

    private final MediaType type;
    private final String fileLocation;

    Media(MediaType type, String fileLocation) {
        this.type = type;
        this.fileLocation = fileLocation;
    }
}
