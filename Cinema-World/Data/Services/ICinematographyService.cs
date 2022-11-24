using Cinema_World.Data.Base;
using Cinema_World.Data.ViewModels;
using Cinema_World.Models;

namespace Cinema_World.Data.Services
{
    public interface ICinematographyService : IEntityBaseRepository<CinematographyModel>
    {
        Task<CinematographyModel> GetCinematographyByIDAsync(int id);

        Task<CinematographyDropdownViewModel> GetCinematographyDropdownValues();

        Task AddNewCinematographyAsync (CinematographyViewModel data);
        Task UpdateCinematographyAsync(CinematographyViewModel data);
    }
}
