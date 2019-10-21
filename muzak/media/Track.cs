using System;
using System.Collections.Generic;
using System.Text;

namespace muzak.media
{
    /** A single media file? */
    class Track
    {
        private readonly Media media;
        private readonly TrackMetadata metadata;
        private readonly TrackOptions options;

        Track(Media media, TrackMetadata metadata, TrackOptions options)
        {
            this.media = media;
            this.metadata = metadata;
            this.options = options;
        }
    }
}
