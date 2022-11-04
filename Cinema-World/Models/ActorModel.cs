using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_World.Models
{
    public class ActorModel
    {
        [Key]
        public int ActorID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int BirthYear { get; set; }
        public string Role { get; set; }

        public  List<Actor_CinematographyModel> Actors_Cinematography { get; set; }
    }
}
