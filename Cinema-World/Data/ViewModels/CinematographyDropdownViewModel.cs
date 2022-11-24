using Cinema_World.Models;

namespace Cinema_World.Data.ViewModels
{
    public class CinematographyDropdownViewModel
    {
        public CinematographyDropdownViewModel()
        {
            Actors = new List<ActorModel>();
            Directors = new List<DirectorModel>();
            Writers = new List<WriterModel>();
            Genres = new List<CinematographyGenreModel>();
            Categories = new List<CinematographyCategoryModel>();
        }

        public List<ActorModel> Actors { get; set; }
        public List<DirectorModel> Directors { get; set; }
        public List<WriterModel> Writers { get; set; }
        public List<CinematographyGenreModel> Genres { get; set; }
        public List<CinematographyCategoryModel> Categories { get; set; }

    }
}
