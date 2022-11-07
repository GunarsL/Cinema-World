using System.ComponentModel.DataAnnotations;

namespace Cinema_World.Models
{
    public class CinematographyCategoryModel
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<CinematographyCategory_CinematographyModel> CinematographyCategories_Cinematography { get; set; }
    }
}
