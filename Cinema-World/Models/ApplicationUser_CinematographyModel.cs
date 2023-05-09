namespace Cinema_World.Models
{
    public class ApplicationUser_CinematographyModel
    {
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }
        public int CinematographyID { get; set; }
        public CinematographyModel Cinematography { get; set; }
        public DateTime UploadTime { get; set; }
    }
}
