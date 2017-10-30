using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaPlayersManager.Models
{
    public class Ranking
    {
        public string PlayerId { get; set; }
        public int RankingVal { get; set; }
        public string PlayerName { get; set; }
        public string Team { get; set; }
        public int NumberOfGames { get; set; }
        public decimal TotalRating { get; set; }
        public decimal AverageRating { get; set; }
        public decimal AverageRatingPer40Mins { get; set; }

    }
}
