using Cinema_World.Data.Base;
using Cinema_World.Models;

namespace Cinema_World.Data.Services
{
    public class DirectorsService : EntityBaseRepository<DirectorModel>, IDirectorsService
    {
        public DirectorsService(ApplicationDbContext context) : base(context) { }
    }
}
