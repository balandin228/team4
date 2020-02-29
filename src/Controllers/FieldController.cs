using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using thegame.Model;

namespace thegame.Controllers
{
    [Route("api/game/[controller]")]
    public class FieldController : Controller
    {
        private IShuffler shuffler;
        public FieldController()
        {
            shuffler = new Shuffler();
        }
        [Route("field")]
        [HttpGet]
        public IActionResult Field()
        {
            return Ok(Game.GenerateField(shuffler));
        }
    }
}
