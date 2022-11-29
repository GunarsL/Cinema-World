using Cinema_World.Data;
using Cinema_World.Data.Services;
using Cinema_World.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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
            var allCinematography = await _service.GetAllAsync(n => n.Genre, d => d.Director, m => m.CinematographyCategories_Cinematography);
            return View(allCinematography);
        }


        public async Task<IActionResult> Filter(string searchString)
        {
            var allCinematography = await _service.GetAllAsync(n => n.Genre, d => d.Director);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allCinematography.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.ShortDescription.ToLower().Contains(searchString.ToLower())).ToList();
                return View("Index", filteredResult);
            }
            
            return View("Index", allCinematography);
        }

        public async Task<IActionResult> Details(int id)
        {
            var cinematographyDetails = await _service.GetCinematographyByIDAsync(id);
            if (cinematographyDetails == null) return View("NotFound");
            return View(cinematographyDetails);
        }

        public async Task<IActionResult> Create()
        {
            var cinematographyDropdownData = await _service.GetCinematographyDropdownValues();

            ViewBag.Genres = new SelectList(cinematographyDropdownData.Genres, "ID", "Name");
            ViewBag.Categories = new SelectList(cinematographyDropdownData.Categories, "ID", "Name");
            ViewBag.Actors = new SelectList(cinematographyDropdownData.Actors, "ID", "FullName");
            ViewBag.Writers = new SelectList(cinematographyDropdownData.Writers, "ID", "FullName");
            ViewBag.Directors = new SelectList(cinematographyDropdownData.Directors, "ID", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CinematographyViewModel cinematography)
        {
            if(!ModelState.IsValid)
            {
                var cinematographyDropdownData = await _service.GetCinematographyDropdownValues();

                ViewBag.Genres = new SelectList(cinematographyDropdownData.Genres, "ID", "Name");
                ViewBag.Categories = new SelectList(cinematographyDropdownData.Categories, "ID", "Name");
                ViewBag.Actors = new SelectList(cinematographyDropdownData.Actors, "ID", "FullName");
                ViewBag.Writers = new SelectList(cinematographyDropdownData.Writers, "ID", "FullName");
                ViewBag.Directors = new SelectList(cinematographyDropdownData.Directors, "ID", "FullName");

                return View(cinematography);
            }
            await _service.AddNewCinematographyAsync(cinematography);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var cinematographyDetails = await _service.GetCinematographyByIDAsync(id);
            if (cinematographyDetails == null) return View("NotFound");

            var response = new CinematographyViewModel()
            {
                ID = cinematographyDetails.ID,
                Name = cinematographyDetails.Name,
                ShortDescription = cinematographyDetails.ShortDescription,
                ReleaseYear = cinematographyDetails.ReleaseYear,
                IMDbScore = cinematographyDetails.IMDbScore,
                DirectorID = cinematographyDetails.DirectorID,
                GenreID = cinematographyDetails.GenreID,
                ActorIDs = cinematographyDetails.Actors_Cinematography.Select(a => a.ActorID).ToList(),
                WriterIDs = cinematographyDetails.Writers_Cinematography.Select(w => w.WriterID).ToList(),
                CinematographyCategoryIDs = cinematographyDetails.CinematographyCategories_Cinematography.Select(c => c.CinematographyCategoryID).ToList(),
            };

            var cinematographyDropdownData = await _service.GetCinematographyDropdownValues();

            ViewBag.Genres = new SelectList(cinematographyDropdownData.Genres, "ID", "Name");
            ViewBag.Categories = new SelectList(cinematographyDropdownData.Categories, "ID", "Name");
            ViewBag.Actors = new SelectList(cinematographyDropdownData.Actors, "ID", "FullName");
            ViewBag.Writers = new SelectList(cinematographyDropdownData.Writers, "ID", "FullName");
            ViewBag.Directors = new SelectList(cinematographyDropdownData.Directors, "ID", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CinematographyViewModel cinematography)
        {
            if (id != cinematography.ID) return View("NotFound");


            if (!ModelState.IsValid)
            {
                var cinematographyDropdownData = await _service.GetCinematographyDropdownValues();

                ViewBag.Genres = new SelectList(cinematographyDropdownData.Genres, "ID", "Name");
                ViewBag.Categories = new SelectList(cinematographyDropdownData.Categories, "ID", "Name");
                ViewBag.Actors = new SelectList(cinematographyDropdownData.Actors, "ID", "FullName");
                ViewBag.Writers = new SelectList(cinematographyDropdownData.Writers, "ID", "FullName");
                ViewBag.Directors = new SelectList(cinematographyDropdownData.Directors, "ID", "FullName");

                return View(cinematography);
            }
            await _service.UpdateCinematographyAsync(cinematography);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var cinematographyDetails = await _service.GetCinematographyByIDAsync(id);
            if (cinematographyDetails == null) return View("NotFound");
            return View(cinematographyDetails);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinematographyDetails = await _service.GetCinematographyByIDAsync(id);
            if (cinematographyDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
