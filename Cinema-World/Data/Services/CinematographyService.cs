using Cinema_World.Data.Base;
using Cinema_World.Models;

namespace Cinema_World.Data.Services
{
    public class CinematographyService : EntityBaseRepository<CinematographyModel>, ICinematographyService
    {
        public CinematographyService(ApplicationDbContext context) : base(context) { }
    }
}
