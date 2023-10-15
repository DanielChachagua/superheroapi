using SuperHero.Models;

namespace SuperHero.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHeroModel>? GetAllHeroes();
        SuperHeroModel? GetHero(int id);
        List<SuperHeroModel> AddHero(SuperHeroModel hero);
        List<SuperHeroModel>? UpdateHero(int id, SuperHeroModel heroe);
        List<SuperHeroModel>? DeleteHero(int id);

    }
}
