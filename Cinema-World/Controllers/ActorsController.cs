using Cinema_World.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cinema_World.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allActors = _context.Actors.ToList();
            return View();
        }
    }
}
