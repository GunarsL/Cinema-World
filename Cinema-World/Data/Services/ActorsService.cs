using Cinema_World.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly ApplicationDbContext _context;
        public ActorsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ActorModel actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorID == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ActorModel>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<ActorModel> GetByIDAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorID == id);
            return result;
        }

        public async Task<ActorModel> UpdateAsync(int id, ActorModel newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
