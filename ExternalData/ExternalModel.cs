using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsScoresAPIDemo.ExternalData
{
    public class TeamsList
    {
        public List<TeamExt> Teams { get; set; }
    }

    public class TeamExt
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public string SquadMarketValue { get; set; }
        public string CrestUrl { get; set; }
    }
}
