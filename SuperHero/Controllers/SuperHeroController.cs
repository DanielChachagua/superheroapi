using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Models;
using SuperHero.Services.SuperHeroService;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    { 
        private readonly ISuperHeroService _superHeroService;
        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
            
        }

        [HttpGet]

        //public async Task<IActionResult> GetAllHeroes()
        public async Task<ActionResult<List<SuperHeroModel>>> GetAllHeroes()
        {
            return Ok(_superHeroService.GetAllHeroes());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHeroModel>> GetSingleHero(int id)
        {
            var result = _superHeroService.GetHero(id);
            if (result == null) return NotFound("Super hero no encontrado");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<SuperHeroModel>> AddHero([FromBody]SuperHeroModel hero)
        {
            return Ok(_superHeroService.AddHero(hero));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHeroModel>>> UpdateHero(int id, SuperHeroModel heroe)
        {
            var result = _superHeroService.UpdateHero(id, heroe);
            if (result == null) return NotFound("Super hero no encontrado");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHeroModel>>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            if (result == null) return NotFound("Super Hero no encontrado");
            return Ok(result);
        }
    }
}
