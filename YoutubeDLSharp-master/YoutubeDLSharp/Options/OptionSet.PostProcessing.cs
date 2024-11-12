﻿// <auto-generated>
// This code was partially generated by a tool.
// </auto-generated>

namespace YoutubeDLSharp.Options
{
    public partial class OptionSet
    {
        private Option<bool> extractAudio = new Option<bool>("-x", "--extract-audio");
        private Option<AudioConversionFormat> audioFormat = new Option<AudioConversionFormat>("--audio-format");
        private Option<byte?> audioQuality = new Option<byte?>("--audio-quality");
        private Option<VideoRecodeFormat> recodeVideo = new Option<VideoRecodeFormat>("--recode-video");
        private Option<string> postprocessorArgs = new Option<string>("--postprocessor-args");
        private Option<bool> keepVideo = new Option<bool>("-k", "--keep-video");
        private Option<bool> noPostOverwrites = new Option<bool>("--no-post-overwrites");
        private Option<bool> embedSubs = new Option<bool>("--embed-subs");
        private Option<bool> embedThumbnail = new Option<bool>("--embed-thumbnail");
        private Option<bool> addMetadata = new Option<bool>("--add-metadata");
        private Option<string> metadataFromTitle = new Option<string>("--metadata-from-title");
        private Option<bool> xattrs = new Option<bool>("--xattrs");
        private Option<string> fixup = new Option<string>("--fixup");
        private Option<bool> preferAvconv = new Option<bool>("--prefer-avconv");
        private Option<bool> preferFfmpeg = new Option<bool>("--prefer-ffmpeg");
        private Option<string> ffmpegLocation = new Option<string>("--ffmpeg-location");
        private Option<string> exec = new Option<string>("--exec");
        private Option<string> convertSubs = new Option<string>("--convert-subs");

        /// <summary>
        /// Convert video files to audio-only files
        /// (requires ffmpeg/avconv and
        /// ffprobe/avprobe)
        /// </summary>
        public bool ExtractAudio { get => extractAudio.Value; set => extractAudio.Value = value; }
        /// <summary>
        /// Specify audio format: &quot;best&quot;, &quot;aac&quot;,
        /// &quot;flac&quot;, &quot;mp3&quot;, &quot;m4a&quot;, &quot;opus&quot;, &quot;vorbis&quot;,
        /// or &quot;wav&quot;; &quot;best&quot; by default; No effect
        /// without -x
        /// </summary>
        public AudioConversionFormat AudioFormat { get => audioFormat.Value; set => audioFormat.Value = value; }
        /// <summary>
        /// Specify ffmpeg/avconv audio quality,
        /// insert a value between 0 (better) and 9
        /// (worse) for VBR or a specific bitrate
        /// like 128K (default 5)
        /// </summary>
        public byte? AudioQuality { get => audioQuality.Value; set => audioQuality.Value = value; }
        /// <summary>
        /// Encode the video to another format if
        /// necessary (currently supported:
        /// mp4|flv|ogg|webm|mkv|avi)
        /// </summary>
        public VideoRecodeFormat RecodeVideo { get => recodeVideo.Value; set => recodeVideo.Value = value; }
        /// <summary>
        /// Give these arguments to the
        /// postprocessor
        /// </summary>
        public string PostprocessorArgs { get => postprocessorArgs.Value; set => postprocessorArgs.Value = value; }
        /// <summary>
        /// Keep the video file on disk after the
        /// post-processing; the video is erased by
        /// default
        /// </summary>
        public bool KeepVideo { get => keepVideo.Value; set => keepVideo.Value = value; }
        /// <summary>
        /// Do not overwrite post-processed files;
        /// the post-processed files are
        /// overwritten by default
        /// </summary>
        public bool NoPostOverwrites { get => noPostOverwrites.Value; set => noPostOverwrites.Value = value; }
        /// <summary>
        /// Embed subtitles in the video (only for
        /// mp4, webm and mkv videos)
        /// </summary>
        public bool EmbedSubs { get => embedSubs.Value; set => embedSubs.Value = value; }
        /// <summary>
        /// Embed thumbnail in the audio as cover
        /// art
        /// </summary>
        public bool EmbedThumbnail { get => embedThumbnail.Value; set => embedThumbnail.Value = value; }
        /// <summary>
        /// Write metadata to the video file
        /// </summary>
        public bool AddMetadata { get => addMetadata.Value; set => addMetadata.Value = value; }
        /// <summary>
        /// Parse additional metadata like song
        /// title / artist from the video title.
        /// The format syntax is the same as
        /// --output. Regular expression with named
        /// capture groups may also be used. The
        /// parsed parameters replace existing
        /// values. Example: --metadata-from-title
        /// &quot;%(artist)s - %(title)s&quot; matches a
        /// title like &quot;Coldplay - Paradise&quot;.
        /// Example (regex): --metadata-from-title
        /// &quot;(?P&lt;artist&gt;.+?) - (?P&lt;title&gt;.+)&quot;
        /// </summary>
        public string MetadataFromTitle { get => metadataFromTitle.Value; set => metadataFromTitle.Value = value; }
        /// <summary>
        /// Write metadata to the video file&#x27;s
        /// xattrs (using dublin core and xdg
        /// standards)
        /// </summary>
        public bool Xattrs { get => xattrs.Value; set => xattrs.Value = value; }
        /// <summary>
        /// Automatically correct known faults of
        /// the file. One of never (do nothing),
        /// warn (only emit a warning),
        /// detect_or_warn (the default; fix file
        /// if we can, warn otherwise)
        /// </summary>
        public string Fixup { get => fixup.Value; set => fixup.Value = value; }
        /// <summary>
        /// Prefer avconv over ffmpeg for running
        /// the postprocessors
        /// </summary>
        public bool PreferAvconv { get => preferAvconv.Value; set => preferAvconv.Value = value; }
        /// <summary>
        /// Prefer ffmpeg over avconv for running
        /// the postprocessors (default)
        /// </summary>
        public bool PreferFfmpeg { get => preferFfmpeg.Value; set => preferFfmpeg.Value = value; }
        /// <summary>
        /// Location of the ffmpeg/avconv binary;
        /// either the path to the binary or its
        /// containing directory.
        /// </summary>
        public string FfmpegLocation { get => ffmpegLocation.Value; set => ffmpegLocation.Value = value; }
        /// <summary>
        /// Execute a command on the file after
        /// downloading and post-processing,
        /// similar to find&#x27;s -exec syntax.
        /// Example: --exec &#x27;adb push {}
        /// /sdcard/Music/ &amp;&amp; rm {}&#x27;
        /// </summary>
        public string Exec { get => exec.Value; set => exec.Value = value; }
        /// <summary>
        /// Convert the subtitles to other format
        /// (currently supported: srt|ass|vtt|lrc)
        /// </summary>
        public string ConvertSubs { get => convertSubs.Value; set => convertSubs.Value = value; }
    }
}
