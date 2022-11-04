using System.ComponentModel.DataAnnotations;

namespace Cinema_World.Models
{
    public class WriterModel
    {
        [Key]
        public int WriterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int MoviesWritten { get; set; }
        public int SeriesWritten { get; set; }

        public List<CinematographyModel> Cinematography { get; set; }

    }
}
