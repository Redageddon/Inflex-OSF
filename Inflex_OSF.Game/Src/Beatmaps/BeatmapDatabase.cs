﻿using System.Collections.Generic;

namespace Infex_OSF.Game.Beatmaps;

public class BeatmapDatabase
{
    public IEnumerable<Beatmap> Beatmaps { get; set; }

    public Beatmap LoadBeatmaps() =>
        //Todo: implement beatmap refinding
        null;

    public void ReloadBeatmaps() => this.LoadBeatmaps();
    //Todo: implement database pulling
}