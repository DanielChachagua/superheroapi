using SuperHero.Models;

namespace SuperHero.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
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
        public List<SuperHeroModel> AddHero(SuperHeroModel hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHeroModel>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null) return null;
            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHeroModel>? GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHeroModel? GetHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null) return null;
            return hero;
        }

        public List<SuperHeroModel>? UpdateHero(int id, SuperHeroModel heroe)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null) return null;
            hero.Apodo = heroe.Apodo;
            hero.Nombre = heroe.Nombre;
            hero.Apellido = heroe.Apellido;
            hero.Lugar = heroe.Lugar;
            return superHeroes;
        }
    }
}
