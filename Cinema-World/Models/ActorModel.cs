using DocumentFormat.OpenXml.Bibliography;
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

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle name")]
        public string? MiddleName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Year of Birth")]
        public int BirthYear { get; set; }

        [Display(Name = "Place of Birth")]
        public string BirthPlace { get; set; }

        public  List<Actor_CinematographyModel> Actors_Cinematography { get; set; }
    }
}
