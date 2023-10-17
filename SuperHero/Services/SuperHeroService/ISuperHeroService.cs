using SuperHero.Models;

namespace SuperHero.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        Task<List<SuperHeroModel>?> GetAllHeroes();
        Task<SuperHeroModel?> GetSingleHero(int id);
        Task<List<SuperHeroModel>?> AddHero(SuperHeroModel hero);
        Task<List<SuperHeroModel>?> UpdateHero(int id, SuperHeroModel heroe);
        Task<List<SuperHeroModel>?> DeleteHero(int id);

    }
}
