using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cricketScoreTrack.Interfaces
{
    interface IBowler
    {
        double BowlerSpeed { get; set; }
        string BowlerType { get; set; }
        int BowlerBallsBowled { get; set; }
        int BowlerMaidens { get; set; }
        int BowlerWickets { get; set; }
        double BowlerStrikeRate { get;}
        double BowlerEconomy { get;}
        int BowlerRunsConceded { get; set; }
        int BowlerOversBowled { get; set; }

    }
}