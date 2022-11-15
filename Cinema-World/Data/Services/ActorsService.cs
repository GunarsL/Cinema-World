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

        public void Add(ActorModel Actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ActorID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ActorModel>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public ActorModel GetById(int ActorID)
        {
            throw new NotImplementedException();
        }

        public ActorModel Update(int ActorID, ActorModel newActor)
        {
            throw new NotImplementedException();
        }
    }
}
