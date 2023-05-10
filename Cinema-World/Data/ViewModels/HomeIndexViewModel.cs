using Cinema_World.Models;

namespace Cinema_World.Data.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<CinematographyModel> Top3AllTimeCinematography { get; set; }
        public List<CinematographyModel> Top3ThisMonthCinematography { get; set; }
    }
}
