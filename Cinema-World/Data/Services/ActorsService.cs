using Cinema_World.Data.Base;
using Cinema_World.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Data.Services
{
    public class ActorsService : EntityBaseRepository<ActorModel>, IActorsService
    {
        public ActorsService(ApplicationDbContext context) : base(context) { }
    }
}
