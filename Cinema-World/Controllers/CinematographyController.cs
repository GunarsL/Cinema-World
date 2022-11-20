using Cinema_World.Data;
using Cinema_World.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Controllers
{
    public class CinematographyController : Controller
    {
        private readonly ICinematographyService _service;

        public CinematographyController(ICinematographyService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinematography = await _service.GetAllAsync();
            return View(allCinematography);
        }
    }
}
