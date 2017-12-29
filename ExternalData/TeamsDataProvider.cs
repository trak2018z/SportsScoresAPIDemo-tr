using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SportsScoresAPIDemo.ExternalData
{
    public class TeamsDataProvider
    {
        public TeamsList GetData(string url)
        {
            TeamsList res = new TeamsList();
            using (var client = new HttpClient())
            {
                var response = client.GetStringAsync(url);
                var stringResult = response.Result;
                res = JsonConvert.DeserializeObject<TeamsList>(stringResult);
            }
            return res;
        }
    }
}
