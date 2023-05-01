using Cinema_World.Data;
using Cinema_World.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Cinema_World.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FavoritesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyFavorites(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                if (!User.Identity.IsAuthenticated)
                {
                    // if the user is not authenticated and no username is provided, redirect to login
                    return RedirectToAction("Login", "Account");
                }
                // if the user is authenticated but no username is provided, use the current user's username
                username = User.Identity.Name;
            }

            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                return View("NotFound");
            }

            var favorites = _context.AspNetUserCinematography
                .Include(uc => uc.Cinematography)
                .ThenInclude(c => c.Genre)
                .Include(uc => uc.Cinematography)
                .ThenInclude(c => c.Actors_Cinematography)
                .ThenInclude(ca => ca.Actor)
                .Include(uc => uc.Cinematography)
                .ThenInclude(c => c.Writers_Cinematography)
                .ThenInclude(cw => cw.Writer)
                .Include(uc => uc.Cinematography)
                .ThenInclude(c => c.Director)
                .Where(uc => uc.UserID == user.Id)
                .Select(uc => uc.Cinematography)
                .ToList();

            return View(favorites);
        }

        [HttpPost]
        public async Task<IActionResult> AddToFavorites(int cinematographyID)
        {
            var username = User.Identity.Name;
            var userID = _userManager.GetUserId(HttpContext.User);

            var favorites = _context.AspNetUserCinematography.FirstOrDefault(r => r.CinematographyID == cinematographyID && r.UserID == userID);
            if (favorites != null)
            {
                return RedirectToAction("MyFavorites", "Favorites");
            }

            var createFavorites = new ApplicationUser_CinematographyModel()
            {
                CinematographyID = cinematographyID,
                UserID = userID
            };

            _context.AspNetUserCinematography.Add(createFavorites);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyFavorites", "Favorites");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromFavorites(int cinematographyID)
        {
            var userID = _userManager.GetUserId(HttpContext.User);

            var favorites = _context.AspNetUserCinematography.FirstOrDefault(r => r.CinematographyID == cinematographyID && r.UserID == userID);
            if (favorites == null)
            {
                return View("NotFound");
            };

            _context.AspNetUserCinematography.Remove(favorites);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Cinematography");
        }
    }
}