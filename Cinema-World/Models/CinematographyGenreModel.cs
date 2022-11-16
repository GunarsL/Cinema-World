using System.ComponentModel.DataAnnotations;

namespace Cinema_World.Models
{
    public class CinematographyGenreModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public List<CinematographyModel> Cinematography { get; set; }
    }
}
