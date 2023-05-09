using Cinema_World.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema_World.Models
{
    public class CinematographyModel : IEntityBase
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Title")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string ShortDescription { get; set; }

        [Display(Name = "Release year")]
        public int ReleaseYear { get; set; }

        [Display(Name = "IMDb score")]
        public double IMDbScore { get; set; }

        [Display(Name = "Picture URL")]
        public string Picture { get; set; }

        public List<Actor_CinematographyModel> Actors_Cinematography { get; set; }
        public List<Writer_CinematographyModel> Writers_Cinematography { get; set; }
        public List<CinematographyCategory_CinematographyModel> CinematographyCategories_Cinematography { get; set; }
        public List<ApplicationUser_CinematographyModel> ApplicationUser_Cinematography { get; set; }

        public int DirectorID { get; set; }
        [ForeignKey("DirectorID")]
        public DirectorModel Director { get; set; }

        public int GenreID { get; set; }
        [ForeignKey("GenreID")]
        public CinematographyGenreModel Genre { get; set; }
    }
}
