namespace Cinema_World.Models
{
    public class CinematographyCategory_CinematographyModel
    {
        public int CinematographyCategoryID { get; set; }
        public CinematographyCategoryModel Category { get; set; }
        public int CinematographyID { get; set; }
        public CinematographyModel Cinematography { get; set; }
    }
}
