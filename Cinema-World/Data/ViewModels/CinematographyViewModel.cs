using Cinema_World.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema_World.Models
{
    public class CinematographyViewModel
    {
        public int ID{ get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Title can be between 1 and 255 characters long!")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Description can be between 1 and 255 characters long!")]
        public string ShortDescription { get; set; }

        [Display(Name = "Release year")]
        [Required(ErrorMessage = "Year of Release is required")]
        [Range(999, 9999, ErrorMessage = "Input a year between 999 and 9999")]
        public int ReleaseYear { get; set; }
        
        [Display(Name = "IMDb score")]
        [Required(ErrorMessage = "IMDb score is required")]
        [Range(0.0,10.0, ErrorMessage = "Input a score between 0.0 and 10.0") ]
        public double IMDbScore { get; set; }

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Actor(s) are required")]
        public List<int> ActorIDs { get; set; }

        [Display(Name = "Select writer(s)")]
        [Required(ErrorMessage = "Writer(s) are required")]
        public List<int> WriterIDs { get; set; }

        [Display(Name = "Select categories")]
        [Required(ErrorMessage = "Categories are required")]
        public List<int> CinematographyCategoryIDs { get; set; }

        [Display(Name = "Select a director")]
        [Required(ErrorMessage = "Director is required")]
        public int DirectorID { get; set; }

        [Display(Name = "Select a genre")]
        [Required(ErrorMessage = "Genre is required")]
        public int GenreID { get; set; }
    }
}
