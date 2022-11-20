using Cinema_World.Data.Base;
using Cinema_World.Models;

namespace Cinema_World.Data.Services
{
    public class WritersService : EntityBaseRepository<WriterModel>, IWritersService
    {
        public WritersService(ApplicationDbContext context) : base(context) { }
    }
}
