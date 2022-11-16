using Cinema_World.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Cinema_World.Models
{
    public class DirectorModel : IEntityBase
    {
        [Key]

        public int ID { get; set; }

        [Required(ErrorMessage = "First name is a required field")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "First name can be between 1 and 100 characters long!")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Middle name can be between 1 and 100 characters long!")]
        public string? MiddleName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is a required field")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Last name can be between 1 and 100 characters long!")]
        public string LastName { get; set; }

        [Display(Name = "Year of Birth")]
        [Required(ErrorMessage = "Year of birth is a required field")]
        [Range(999, 9999, ErrorMessage = "Input a year between 999 and 9999")]
        public int BirthYear { get; set; }

        [Display(Name = "Place of Birth")]
        [Required(ErrorMessage = "Place of birth is a required field")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name of the place can be between 1 and 100 characters long!")]
        public string BirthPlace { get; set; }

        public List<CinematographyModel>? Cinematography { get; set; }
    }
}
