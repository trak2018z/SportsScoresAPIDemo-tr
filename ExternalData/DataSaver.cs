using SportsScoresAPIDemo.Model;
using SportsScoresAPIDemo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsScoresAPIDemo.ExternalData
{
    public class DataSaver
    {
        private ApplicationDbContext _context;

        public DataSaver(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SaveCompetitionTeams(TeamsList teams)
        {
            List<TeamEntity> teamEntities = new List<TeamEntity>();
            foreach (var item in teams.Teams)
            {
                TeamEntity team = new TeamEntity
                {
                    Code = item.Code,
                    CrestURL = item.CrestUrl,
                    MarektValue = item.SquadMarketValue,
                    Name = item.Name,
                    ShortName = item.ShortName
                };
                teamEntities.Add(team);
            }
            _context.Teams.AddRange(teamEntities);
            _context.SaveChanges();
        }
    }
}
