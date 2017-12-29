using SportsScoresAPIDemo.ExternalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsScoresAPIDemo.Model
{
    public static class DbInitializer
    {
        private const string ApiUrl = @"http://api.football-data.org/v1/competitions/";
        private const int CompetitionId = 445;

        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Teams.Any())
            {
                return;
            }

            var reader = new TeamsDataProvider();
            var teamsData = reader.GetData($"{ApiUrl}{CompetitionId}/teams");
            var saver = new DataSaver(context);
            saver.SaveCompetitionTeams(teamsData);
        }
    }
}
