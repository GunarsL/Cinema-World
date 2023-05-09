using Cinema_World.Data.Base;
using Cinema_World.Data.ViewModels;
using Cinema_World.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema_World.Data.Services
{
    public class CinematographyService : EntityBaseRepository<CinematographyModel>, ICinematographyService
    {
        private readonly ApplicationDbContext _context;
        public CinematographyService(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task AddNewCinematographyAsync(CinematographyViewModel data)
        {
            var newCinematography = new CinematographyModel()
            {
                Name = data.Name,
                Picture = data.Picture,
                ShortDescription = data.ShortDescription,
                ReleaseYear = data.ReleaseYear,
                IMDbScore = data.IMDbScore,
                DirectorID = data.DirectorID,
                GenreID = data.GenreID,
            };
            await _context.AddAsync(newCinematography);
            await _context.SaveChangesAsync();

            foreach (var writerID in data.WriterIDs)
            {
                var newWriterCinematography = new Writer_CinematographyModel()
                {
                    CinematographyID = newCinematography.ID,
                    WriterID = writerID 
                };
                await _context.Writers_Cinematography.AddAsync(newWriterCinematography);
            }
            foreach (var actorID in data.ActorIDs)
            {
                var newActorCinematography = new Actor_CinematographyModel()
                {
                    CinematographyID = newCinematography.ID,
                    ActorID = actorID
                };
                await _context.Actors_Cinematography.AddAsync(newActorCinematography);
            }
            foreach (var categoryID in data.CinematographyCategoryIDs)
            {
                var newCategoryCinematography = new CinematographyCategory_CinematographyModel()
                {
                    CinematographyID = newCinematography.ID,
                    CinematographyCategoryID = categoryID
                };
                await _context.CinematographyCategories_Cinematography.AddAsync(newCategoryCinematography);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<CinematographyModel> GetCinematographyByIDAsync(int id)
        {
            var cinematographyDetails = await _context.Cinematography
                .Include(d => d.Director)
                .Include(g => g.Genre)
                .Include(ac => ac.Actors_Cinematography).ThenInclude(a => a.Actor)
                .Include(wc => wc.Writers_Cinematography).ThenInclude(w => w.Writer)
                .Include(cc => cc.CinematographyCategories_Cinematography).ThenInclude(c => c.Category)
                .FirstOrDefaultAsync(n => n.ID == id);

            return cinematographyDetails;
        }

        public async Task<CinematographyDropdownViewModel> GetCinematographyDropdownValues()
        {
            var response = new CinematographyDropdownViewModel()
            {
                Actors = await _context.Actors.OrderBy(a => a.LastName).ToListAsync(),
                Writers = await _context.Writers.OrderBy(w => w.LastName).ToListAsync(),
                Directors = await _context.Directors.OrderBy(d => d.LastName).ToListAsync(),
                Categories = await _context.CinematographyCategories.OrderBy(c => c.Name).ToListAsync(),
                Genres = await _context.CinematographyGenres.OrderBy(g => g.Name).ToListAsync()
            };

            return response;
        }

        public async Task UpdateCinematographyAsync(CinematographyViewModel data)
        {
            var dbCinematography = await _context.Cinematography.FirstOrDefaultAsync(c => c.ID == data.ID);
            if (dbCinematography != null)
            {
                dbCinematography.Name = data.Name;
                dbCinematography.Picture = data.Picture;
                dbCinematography.ShortDescription = data.ShortDescription;
                dbCinematography.ReleaseYear = data.ReleaseYear;
                dbCinematography.IMDbScore = data.IMDbScore;
                dbCinematography.DirectorID = data.DirectorID;
                dbCinematography.GenreID = data.GenreID;
                await _context.SaveChangesAsync();
            }

            var existingWritersDB = _context.Writers_Cinematography.Where(n => n.CinematographyID == data.ID).ToList();
            _context.Writers_Cinematography.RemoveRange(existingWritersDB);
            await _context.SaveChangesAsync();

            foreach (var writerID in data.WriterIDs)
            {
                var newWriterCinematography = new Writer_CinematographyModel()
                {
                    CinematographyID = data.ID,
                    WriterID = writerID
                };
                await _context.Writers_Cinematography.AddAsync(newWriterCinematography);
            }

            var existingActorsDB = _context.Actors_Cinematography.Where(n => n.CinematographyID == data.ID).ToList();
            _context.Actors_Cinematography.RemoveRange(existingActorsDB);
            await _context.SaveChangesAsync();

            foreach (var actorID in data.ActorIDs)
            {
                var newActorCinematography = new Actor_CinematographyModel()
                {
                    CinematographyID = data.ID,
                    ActorID = actorID
                };
                await _context.Actors_Cinematography.AddAsync(newActorCinematography);
            }

            var existingCategoriesDB = _context.CinematographyCategories_Cinematography.Where(n => n.CinematographyID == data.ID).ToList();
            _context.CinematographyCategories_Cinematography.RemoveRange(existingCategoriesDB);
            await _context.SaveChangesAsync();

            foreach (var categoryID in data.CinematographyCategoryIDs)
            {
                var newCategoryCinematography = new CinematographyCategory_CinematographyModel()
                {
                    CinematographyID = data.ID,
                    CinematographyCategoryID = categoryID
                };
                await _context.CinematographyCategories_Cinematography.AddAsync(newCategoryCinematography);
            }

            await _context.SaveChangesAsync();
        }
    }
}
