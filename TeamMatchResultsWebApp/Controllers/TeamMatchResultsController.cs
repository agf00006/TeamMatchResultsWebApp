
using Microsoft.AspNetCore.Mvc;
using APItest.Repositories;
using APItest.Entities;
using TeamMatchResultsWebApp.Repositories;

namespace APItest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMatchResultsController : Controller
    {
        private readonly ITeamMatchResults teammatches;

        public TeamMatchResultsController(ITeamMatchResults teammatches)
        {
            this.teammatches = teammatches;
        }

        [HttpGet("{teamID}")]
        public async Task<ActionResult<List<TeamMatchResults>>> GetTeamMatchResults(int teamID)
        {
            var results = await teammatches.GetTeamMatchResults(teamID);
            if (results == null)
            {
                return NotFound();
            }
            return results;
        }
    }
}

