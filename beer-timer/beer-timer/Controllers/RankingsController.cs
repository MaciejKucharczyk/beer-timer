using beer_timer.Interfaces;
using beer_timer.Models;
using Microsoft.AspNetCore.Mvc;

namespace beer_timer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankingsController : Controller
    {
        private IRankingService _irankingService;

        public RankingsController(IRankingService irankingService)
        {
            _irankingService = irankingService;
        }

        [HttpGet("")]
        public IActionResult GetRankings()
        {
            var rankings = _irankingService.GetRankingList();
            return Ok(rankings);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetRanking(int id)
        {
            var rankings = _irankingService.GetRankingById(id);
            return Ok(rankings);
        }

        [HttpPost("")]
        public IActionResult CreateRanking([FromBody] Ranking ranking)
        {
            var id = _irankingService.CreateRanking(ranking);
            return Created($"api/rankings/{id}", id);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateRanking([FromRoute] int id, [FromBody] Ranking ranking)
        {
            bool isUpdated = _irankingService.UpdateRanking(id, ranking);
            if(isUpdated)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteRanking([FromRoute] int id)
        {
            bool isDeleted = _irankingService.DeleteRanking(id);
            if(isDeleted)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
