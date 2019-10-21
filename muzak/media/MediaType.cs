namespace muzak.media
{
    class MediaType
    {
        // TODO(stfinancial): Should this also be used for album artwork?
        public static readonly MediaType FLAC = new MediaType(".flac");
        public static readonly MediaType MP3 = new MediaType(".mp3");
        public static readonly MediaType WAV = new MediaType(".wav");

        public string Extension { get; private set; }

        private MediaType(string extension) => (Extension) = (extension);
    }
}
