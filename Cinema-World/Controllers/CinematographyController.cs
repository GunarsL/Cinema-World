using Cinema_World.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Controllers
{
    public class CinematographyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CinematographyController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allCinematography = await _context.Cinematography.ToListAsync();
            return View(allCinematography);
        }
    }
}
