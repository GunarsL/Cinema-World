using Microsoft.AspNetCore.Identity;
using Nest;
using System.ComponentModel.DataAnnotations;

namespace Cinema_World.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<ApplicationUser_CinematographyModel> ApplicationUser_Cinematography { get; set; }
    }
}
