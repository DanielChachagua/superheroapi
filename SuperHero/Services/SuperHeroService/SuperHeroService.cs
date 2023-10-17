using System.Data;
using SuperHero.Models;

namespace SuperHero.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        
        private readonly DataContext _context;

        public SuperHeroService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SuperHeroModel>?> AddHero(SuperHeroModel hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            return await _context.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHeroModel>?> DeleteHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null) return null;
            _context.SuperHeroes.Remove(hero);
            await _context.SaveChangesAsync();
            return await _context.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHeroModel>?> GetAllHeroes()
        {
            var heroes = await _context.SuperHeroes.ToListAsync();
            return heroes;
        }

        public async Task<SuperHeroModel?> GetSingleHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null) return null;
            return hero;
        }

        public async Task<List<SuperHeroModel>?> UpdateHero(int id, SuperHeroModel heroe)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null) return null;
            hero.Apodo = heroe.Apodo;
            hero.Nombre = heroe.Nombre;
            hero.Apellido = heroe.Apellido;
            hero.Lugar = heroe.Lugar;

            await _context.SaveChangesAsync();
            return await _context.SuperHeroes.ToListAsync();
        }

        
    }
}
