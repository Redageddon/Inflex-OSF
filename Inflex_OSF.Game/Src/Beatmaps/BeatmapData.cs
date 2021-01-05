using Infex_OSF.Game.Interfaces;

namespace Infex_OSF.Game.Beatmaps
{
    public class BeatmapMetadata : IDatabaseMarker
    {
        public int Id { get; set; }

        public string Icon { get; set; }

        public string Path { get; set; }

        public string SongFile { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Mapper { get; set; }
    }
}