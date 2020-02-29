using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace thegame.Controllers
{
    public  class sosDTO
    {
        public int kkk;
        public List<double> someList;

        public sosDTO(int kkk)
        {
            this.kkk = kkk;
            someList = new List<double>() {3.33, 15};
        }
    }

    [Route("api/game/[controller]")]
    public class LeaderBoardController : Controller
    {
        [Produces("application/json")]
        [HttpGet("get")]
        public IActionResult GetLeaderBoard()
        {
            return Ok(new sosDTO(13));
        }
        
        [HttpPost]
        public IActionResult PostGameResult([FromBody] string name, [FromBody] int score)
        {
            throw new NotImplementedException();
        }
    }
}
