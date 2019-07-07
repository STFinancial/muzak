package media;

/**
 * Created by Timothy on 7/7/19.
 */
public enum MediaType {
    // TODO(stfinancial): Should this also be used for album artwork?
    FLAC(".flac"),
    MP3(".mp3"),
    WAV(".wav");

    private String extension;

    private MediaType(String extension) {
        this.extension = extension;
    }

    public String getExtension() { return extension; }
}
