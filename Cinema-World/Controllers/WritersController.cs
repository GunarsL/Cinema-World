using Cinema_World.Data;
using Cinema_World.Data.Services;
using Cinema_World.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Controllers
{
    public class WritersController : Controller
    {
        private readonly IWritersService _service;

        public WritersController(IWritersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allWriters = await _service.GetAllAsync();
            return View(allWriters);
        }

        public async Task<IActionResult> Details(int id)
        {
            var writerDetails = await _service.GetByIDAsync(id);
            if (writerDetails == null) return View("NotFound");
            return View(writerDetails);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName,MiddleName,LastName,BirthYear,BirthPlace")] WriterModel writer)
        {
            if (!ModelState.IsValid)
            {
                return View(writer);
            }
            await _service.AddAsync(writer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var writerDetails = await _service.GetByIDAsync(id);
            if (writerDetails == null) return View("NotFound");
            return View(writerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, WriterModel writer)
        {
            if (!ModelState.IsValid)
            {
                return View(writer);
            }
            await _service.UpdateAsync(id, writer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var writerDetails = await _service.GetByIDAsync(id);
            if (writerDetails == null) return View("NotFound");
            return View(writerDetails);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var writerDetails = await _service.GetByIDAsync(id);
            if (writerDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
