using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Models;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<SuperHeroModel> superHeroes = new List<SuperHeroModel>
        {
            new SuperHeroModel
                {   Id = 1,
                    Apodo = "spider man",
                    Nombre = "peter",
                    Apellido = "parker",
                    Lugar = "new york"
                },
            new SuperHeroModel
                {   Id = 2,
                    Apodo = "super man",
                    Nombre = "clark",
                    Apellido = "ken",
                    Lugar = "metrocidad"
                }
        };
        [HttpGet]

        //public async Task<IActionResult> GetAllHeroes()
        public async Task<ActionResult<List<SuperHeroModel>>> GetAllHeroes()
        {
            //var superHeroes = new List<SuperHeroModel>
            //{
            //    new SuperHeroModel
            //    {   Id = 1,
            //        Apodo = "Spider Man",
            //        Nombre = "peter",
            //        Apellido = "Parker",
            //        Lugar = "New York"
            //    }
            //};
            return Ok(superHeroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHeroModel>> GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null) return NotFound("este heroe no existe");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<SuperHeroModel>> AddHero([FromBody]SuperHeroModel hero)
        {
            superHeroes.Add(hero);
            return Ok(superHeroes);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHeroModel>>> UpdateHero(int id, SuperHeroModel heroe)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null) return NotFound("este heroe no existe");
            hero.Apodo= heroe.Apodo;
            hero.Nombre= heroe.Nombre;
            hero.Apellido= heroe.Apellido;
            hero.Lugar= heroe.Lugar;
            return Ok(superHeroes);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHeroModel>>> DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null) return NotFound("este heroe no existe");
            superHeroes.Remove(hero);
            return Ok(superHeroes);
        }
    }
}
