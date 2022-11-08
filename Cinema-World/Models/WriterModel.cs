using System.ComponentModel.DataAnnotations;

namespace Cinema_World.Models
{
    public class WriterModel
    {
        [Key]
        public int WriterID { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }

        public List<Writer_CinematographyModel> Writers_Cinematography { get; set; }

    }
}
