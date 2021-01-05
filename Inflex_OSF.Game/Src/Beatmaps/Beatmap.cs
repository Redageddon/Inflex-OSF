using System.Collections.Generic;
using Infex_OSF.Game.Beatmaps.Events;

namespace Infex_OSF.Game.Beatmaps
{
    public class Beatmap : BeatmapMetadata
    {
        public int DrainRate { get; set; }

        public string BackgroundPath { get; set; }

        public IEnumerable<EnemyEvent> Enemies { get; }
    }
}