using SportsScoresAPIDemo.Model;
using SportsScoresAPIDemo.Model.DTO;
using SportsScoresAPIDemo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsScoresAPIDemo.Services
{
    public class TeamsService
    {
        private ApplicationDbContext context;

        public TeamsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public TeamDTO GetTeamById(int teamId)
        {
            var team = context.Teams.FirstOrDefault(t => t.TeamId == teamId);
            if(team == null)
            {
                return null;
            }
            return MapEntityToDTO(team);
        }

        public IEnumerable<TeamDTO> GetAllTeams()
        {
            return context.Teams.Select(t => MapEntityToDTO(t));
        }

        private TeamDTO MapEntityToDTO(TeamEntity entity)
        {
            return new TeamDTO
            {
                Code = entity.Code,
                CrestURL = entity.CrestURL,
                MarektValue = entity.MarektValue,
                Name = entity.Name,
                ShortName = entity.ShortName,
                TeamId = entity.TeamId
            };
        }
    }
}
