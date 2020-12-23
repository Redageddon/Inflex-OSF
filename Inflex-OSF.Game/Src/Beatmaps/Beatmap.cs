using System.Collections.Generic;
using SceneLessLogic.Beatmaps.Events;

namespace SceneLessLogic.Beatmaps
{
    public class Beatmap : BeatmapMetadata
    {
        public int DrainRate { get; set; }

        public string BackgroundPath { get; set; }

        public IEnumerable<EnemyEvent> Enemies { get; }
    }
}