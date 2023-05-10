using Cinema_World.Data;
using Cinema_World.Data.ViewModels;
using Cinema_World.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace Cinema_World.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var top3AllTime = _context.AspNetUserCinematography
                .Join(
                    _context.Cinematography,
                    a => a.CinematographyID,
                    c => c.ID,
                    (a, c) => new { Outer = a, Inner = c }
                )
                .AsEnumerable()
                .GroupBy(ti => ti.Inner)
                .OrderByDescending(g => g.Count())
                .Take(3)
                .Select(g => g.Key)
                .ToList();

            var currentDate = DateTime.Now;
            var top3ThisMonth = _context.AspNetUserCinematography
                .Join(
                    _context.Cinematography,
                    a => a.CinematographyID,
                    c => c.ID,
                    (a, c) => new { Outer = a, Inner = c }
                )
                .AsEnumerable()
                .Where(ti => ti.Outer.UploadTime.Year == currentDate.Year && ti.Outer.UploadTime.Month == currentDate.Month)
                .GroupBy(ti => ti.Inner)
                .OrderByDescending(g => g.Count())
                .Take(3)
                .Select(g => g.Key)
                .ToList();

            var viewModel = new HomeIndexViewModel()
            {
                Top3AllTimeCinematography = top3AllTime,
                Top3ThisMonthCinematography = top3ThisMonth
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}