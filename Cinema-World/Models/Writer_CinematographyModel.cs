namespace Cinema_World.Models
{
    public class Writer_CinematographyModel
    {
        public int WriterID { get; set; }
        public WriterModel Writer { get; set; }
        public int CinematographyID { get; set; }
        public CinematographyModel Cinematography { get; set; }
    }
}
