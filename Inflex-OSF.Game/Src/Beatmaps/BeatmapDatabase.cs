using System.Collections.Generic;
using SceneLessLogic.Beatmaps;

namespace Inflex_OSF.Screens
{
    public class BeatmapDatabase
    {
        public IEnumerable<Beatmap> Beatmaps { get; set; }

        public BeatmapDatabase()
        {
            //Todo: implement database pulling
        }

        public void ReloadBeatmaps()
        {
            this.LoadBeatmaps();
            //Todo: implement database pulling
        }

        public Beatmap LoadBeatmaps()
        {
            //Todo: implement beatmap refinding
            return null;
        }
    }
}