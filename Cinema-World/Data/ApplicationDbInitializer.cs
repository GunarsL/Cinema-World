using Cinema_World.Data.Static;
using Cinema_World.Models;
using Microsoft.AspNetCore.Identity;

namespace Cinema_World.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                //Makes sure, that database is created
                context.Database.EnsureCreated();
                
                //If Actors table is empty, adds this information
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<ActorModel>()
                    {
                        new ActorModel()
                        {
                            FirstName = "Will",
                            LastName = "Smith",
                            BirthYear = 1968,
                            BirthPlace = "USA"
                        },
                        new ActorModel()
                        {
                            FirstName = "Christian",
                            LastName = "Bale",
                            BirthYear = 1974,
                            BirthPlace = "UK"
                        },
                        new ActorModel()
                        {
                            FirstName = "Tom",
                            LastName = "Cruise",
                            BirthYear = 1962,
                            BirthPlace = "USA"
                        },
                        new ActorModel()
                        {
                            FirstName = "Robert",
                            LastName = "Downey",
                            BirthYear = 1965,
                            BirthPlace = "USA"
                        },
                        new ActorModel()
                        {
                            FirstName = "Chris",
                            LastName = "Hemsworth",
                            BirthYear = 1983,
                            BirthPlace = "Australia"
                        },
                        new ActorModel()
                        {
                            FirstName = "Robert",
                            MiddleName = "De",
                            LastName = "Niro",
                            BirthYear = 1943,
                            BirthPlace = "USA"
                        },
                        new ActorModel()
                        {
                            FirstName = "Mark",
                            LastName = "Ruffalo",
                            BirthYear = 1967,
                            BirthPlace = "USA"
                        },
                        new ActorModel()
                        {
                            FirstName = "Chris",
                            LastName = "Evans",
                            BirthYear = 1981,
                            BirthPlace = "USA"
                        },
                        new ActorModel()
                        {
                            FirstName = "Michael",
                            LastName = "Caine",
                            BirthYear = 1933,
                            BirthPlace = "UK"
                        },
                        new ActorModel()
                        {
                            FirstName = "Morgan",
                            LastName = "Freeman",
                            BirthYear = 1937,
                            BirthPlace = "USA"
                        }
                    });
                    context.SaveChanges();
                }
                
                //If CinematographyCategories table is empty, adds this information
                if (!context.CinematographyCategories.Any())
                {
                    context.CinematographyCategories.AddRange(new List<CinematographyCategoryModel>()
                    {
                        new CinematographyCategoryModel()
                        {
                            Name = "Horror"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Adventure"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Action"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Thriller"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Comedy"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Drama"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Mystery"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Romance"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Sci-Fi"
                        },
                        new CinematographyCategoryModel()
                        {
                            Name = "Crime"
                        }
                    });
                    context.SaveChanges();
                }
                //If CinematographyGenres table is empty, adds this information
                if (!context.CinematographyGenres.Any())
                {
                    context.CinematographyGenres.AddRange(new List<CinematographyGenreModel>()
                    {
                        new CinematographyGenreModel()
                        {
                            Name = "Film"
                        },
                        new CinematographyGenreModel()
                        {
                            Name = "Short-Film"
                        },
                        new CinematographyGenreModel()
                        {
                            Name = "Series"
                        },
                        new CinematographyGenreModel()
                        {
                            Name = "Mini-Series"
                        }
                    });
                    context.SaveChanges();
                }
                
                //If Directors table is empty, adds this information
                if (!context.Directors.Any())
                {
                    context.Directors.AddRange(new List<DirectorModel>()
                    {
                        new DirectorModel()
                        {
                            FirstName = "Christopher",
                            LastName = "Nolan",
                            BirthYear = 1970,
                            BirthPlace = "UK"
                        },
                        new DirectorModel()
                        {
                            FirstName = "Steven",
                            LastName = "Spielberg",
                            BirthYear = 1946,
                            BirthPlace = "USA"
                        },
                        new DirectorModel()
                        {
                            FirstName = "Jonathan",
                            LastName = "Nolan",
                            BirthYear = 1976,
                            BirthPlace = "UK"
                        },
                        new DirectorModel()
                        {
                            FirstName = "Quentin",
                            LastName = "Tarantino",
                            BirthYear = 1963,
                            BirthPlace = "USA"
                        },
                        new DirectorModel()
                        {
                            FirstName = "Anthony",
                            LastName = "Russo",
                            BirthYear = 1970,
                            BirthPlace = "USA"
                        },
                        new DirectorModel()
                        {
                            FirstName = "Joseph",
                            LastName = "Russo",
                            BirthYear = 1971,
                            BirthPlace = "USA"
                        }
                    });
                    context.SaveChanges();
                }
                
                //If Writers table is empty, adds this information
                if (!context.Writers.Any())
                {
                    context.Writers.AddRange(new List<WriterModel>()
                    {
                        new WriterModel()
                        {
                            FirstName = "Quentin",
                            LastName = "Tarantino",
                            BirthYear = 1963,
                            BirthPlace = "USA"
                        },
                        new WriterModel()
                        {
                            FirstName = "Joseph",
                            LastName = "Russo",
                            BirthYear = 1971,
                            BirthPlace = "USA"
                        },
                        new WriterModel()
                        {
                            FirstName = "Christopher",
                            LastName = "Markus",
                            BirthYear = 1963,
                            BirthPlace = "USA"
                        },
                        new WriterModel()
                        {
                            FirstName = "Stan",
                            LastName = "Lee",
                            BirthYear = 1970,
                            BirthPlace = "USA"
                        },
                        new WriterModel()
                        {
                            FirstName = "Stephen",
                            LastName = "McFeely",
                            BirthYear = 1970,
                            BirthPlace = "USA"
                        },
                        new WriterModel()
                        {
                            FirstName = "Jonathan",
                            LastName = "Nolan",
                            BirthYear = 1976,
                            BirthPlace = "UK"
                        },
                        new WriterModel()
                        {
                            FirstName = "Christopher",
                            LastName = "Nolan",
                            BirthYear = 1970,
                            BirthPlace = "UK"
                        }
                    });
                    context.SaveChanges();
                }

                //If Cinematography table is empty, adds this information
                if (!context.Cinematography.Any())
                {
                    context.Cinematography.AddRange(new List<CinematographyModel>()
                    {
                        new CinematographyModel()
                        {
                            Name = "Avengers: Endgame",
                            ShortDescription = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                            ReleaseYear = 2019,
                            IMDbScore = 8.4,
                            DirectorID = 5,
                            GenreID = 1
                        },
                        new CinematographyModel()
                        {
                            Name = "The Dark Knight",
                            ShortDescription = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                            ReleaseYear = 2018,
                            IMDbScore = 8.4,
                            DirectorID = 5,
                            GenreID = 1
                        },
                        new CinematographyModel()
                        {
                            Name = "Avengers: Infinity War",
                            ShortDescription = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            ReleaseYear = 2008,
                            IMDbScore = 8.4,
                            DirectorID = 5,
                            GenreID = 1
                        }
                    });
                    context.SaveChanges();
                }

                //If Writers_Cinematography table is empty, adds this information
                if (!context.Writers_Cinematography.Any())
                {
                    context.Writers_Cinematography.AddRange(new List<Writer_CinematographyModel>()
                    {
                        new Writer_CinematographyModel()
                        {
                            WriterID = 3,
                            CinematographyID = 3
                        },
                        new Writer_CinematographyModel()
                        {
                            WriterID = 4,
                            CinematographyID = 3
                        },
                        new Writer_CinematographyModel()
                        {
                            WriterID = 5,
                            CinematographyID = 3
                        },

                        new Writer_CinematographyModel()
                        {
                            WriterID = 6,
                            CinematographyID = 2
                        },
                        new Writer_CinematographyModel()
                        {
                            WriterID = 7,
                            CinematographyID = 2
                        },

                        new Writer_CinematographyModel()
                        {
                            WriterID = 3,
                            CinematographyID = 1
                        },
                        new Writer_CinematographyModel()
                        {
                            WriterID = 4,
                            CinematographyID = 1
                        },
                        new Writer_CinematographyModel()
                        {
                            WriterID = 5,
                            CinematographyID = 1
                        }
                    });
                    context.SaveChanges();
                }

                //If Actors_Cinematography table is empty, adds this information
                if (!context.Actors_Cinematography.Any())
                {
                    context.Actors_Cinematography.AddRange(new List<Actor_CinematographyModel>()
                    {
                        new Actor_CinematographyModel()
                        {
                            ActorID = 2,
                            CinematographyID = 2
                        },
                        new Actor_CinematographyModel()
                        {
                            ActorID = 9,
                            CinematographyID = 2
                        },
                        new Actor_CinematographyModel()
                        {
                            ActorID = 10,
                            CinematographyID = 2
                        },

                        new Actor_CinematographyModel()
                        {
                            ActorID = 4,
                            CinematographyID = 1
                        },
                        new Actor_CinematographyModel()
                        {
                            ActorID = 7,
                            CinematographyID = 1
                        },
                        new Actor_CinematographyModel()
                        {
                            ActorID = 8,
                            CinematographyID = 1
                        },
                        new Actor_CinematographyModel()
                        {
                            ActorID = 4,
                            CinematographyID = 3
                        },
                        new Actor_CinematographyModel()
                        {
                            ActorID = 5,
                            CinematographyID = 3
                        },
                        new Actor_CinematographyModel()
                        {
                            ActorID = 8,
                            CinematographyID = 3
                        },
                    });
                    context.SaveChanges();
                }

                //If CinematographyCategories_Cinematography table is empty, adds this information
                if (!context.CinematographyCategories_Cinematography.Any())
                {
                    context.CinematographyCategories_Cinematography.AddRange(new List<CinematographyCategory_CinematographyModel>()
                    {
                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 2,
                            CinematographyID = 1,
                        },
                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 3,
                            CinematographyID = 1,
                        },
                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 6,
                            CinematographyID = 1,
                        },

                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 2,
                            CinematographyID = 2,
                        },
                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 3,
                            CinematographyID = 2,
                        },
                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 9,
                            CinematographyID = 2,
                        },
                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 3,
                            CinematographyID = 3,
                        },
                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 6,
                            CinematographyID = 3,
                        },
                        new CinematographyCategory_CinematographyModel()
                        {
                            CinematographyCategoryID = 10,
                            CinematographyID = 3,
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Role creation
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var adminUserEmail = "admin@cinemaworld.com";

                //Admin
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        UserName = "Admin",
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                    };
                    await userManager.CreateAsync(newAdminUser, "CinemaWorld@2022");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                //User
                var cwUserEmail = "cwuser@cinemaworld.com";
                var cwUser = await userManager.FindByEmailAsync(cwUserEmail);
                if (cwUser == null)
                {
                    var newCwUser = new ApplicationUser()
                    {
                        UserName = "CW-User",
                        Email = cwUserEmail,
                        EmailConfirmed = true,
                    };
                    await userManager.CreateAsync(newCwUser, "CinemaWorld@2022");
                    await userManager.AddToRoleAsync(newCwUser, UserRoles.User);
                }
            }
        }
    }
}
