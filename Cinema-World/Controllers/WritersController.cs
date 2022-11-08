using Cinema_World.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Controllers
{
    public class WritersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WritersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allWriters = await _context.Writers.ToListAsync();
            return View();
        }
    }
}
