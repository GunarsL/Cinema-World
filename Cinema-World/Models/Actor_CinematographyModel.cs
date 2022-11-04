namespace Cinema_World.Models
{
    public class Actor_CinematographyModel
    {
        public int ActorID { get; set; }
        public ActorModel Actor { get; set; }
        public int CinematographyID { get; set; }
        public CinematographyModel Cinematography { get; set; }
    }
}
