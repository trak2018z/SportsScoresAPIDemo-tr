using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsScoresAPIDemo.Services;

namespace SportsScoresAPIDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/teams")]
    public class TeamsController : Controller
    {
        private TeamsService _service;

        public TeamsController(TeamsService service)
        {
            this._service = service;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var res = _service.GetTeamById(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllTeams());
        }
    }
}