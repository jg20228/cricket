using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cricketScoreTrack.Interfaces
{
    interface IBatter
    {
        int BatsmanRuns { get; set; }
        int BatsmanBallsFaced { get; set; }
        int BatsmanMatch4s { get; set; }
        int BatsmanMatch6s { get; set; }
        double BatsmanBattingStrikeRate { get;}

    }
}