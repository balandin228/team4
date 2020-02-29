using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace thegame.Controllers
{
    [Route("api/game")]
    public class LeaderBoardController : Controller
    {

        [HttpGet("leaderboard")]
        public IActionResult GetLeaderBoard()
        {
            return Ok(50);
        }

        [HttpPost("leaderboard")]
        public IActionResult PostGameResult([FromBody] string name, [FromBody] int score)
        {
            throw new NotImplementedException();
        }
    }
}
