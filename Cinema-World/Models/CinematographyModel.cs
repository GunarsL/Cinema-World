using Cinema_World.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema_World.Models
{
    public class CinematographyModel
    {
        [Key]
        public int CinematographyID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public DateTime ReleaseDate { get; set; }
        public CinematographyCategory Category { get; set; }
        public CinematographyGenre Genre { get; set; }

        public List<Actor_CinematographyModel> Actors_Cinematography { get; set; }

        public int DirectorID { get; set; }
        [ForeignKey("DirectorID")]
        public DirectorModel Director { get; set; }

        public int WriterID { get; set; }
        [ForeignKey("WriterID")]
        public WriterModel Writer { get; set; }
    }
}
