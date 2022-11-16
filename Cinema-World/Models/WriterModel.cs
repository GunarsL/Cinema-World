using System.ComponentModel.DataAnnotations;

namespace Cinema_World.Models
{
    public class WriterModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle name")]
        public string? MiddleName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Year of Birth")]
        public int BirthYear { get; set; }

        [Display(Name = "Place of Birth")]
        public string BirthPlace { get; set; }

        public List<Writer_CinematographyModel> Writers_Cinematography { get; set; }

    }
}
