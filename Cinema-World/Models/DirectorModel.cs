using System.ComponentModel.DataAnnotations;

namespace Cinema_World.Models
{
    public class DirectorModel
    {
        [Key]

        public int DirectorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }

        public List<CinematographyModel> Cinematography { get; set; }
    }
}
