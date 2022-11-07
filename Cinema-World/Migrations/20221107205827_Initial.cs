using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema_World.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorID);
                });

            migrationBuilder.CreateTable(
                name: "CinematographyCategories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinematographyCategories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "CinematographyGenres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinematographyGenres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirectorID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriterID);
                });

            migrationBuilder.CreateTable(
                name: "Cinematography",
                columns: table => new
                {
                    CinematographyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IMDbScore = table.Column<double>(type: "float", nullable: false),
                    DirectorID = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinematography", x => x.CinematographyID);
                    table.ForeignKey(
                        name: "FK_Cinematography_CinematographyGenres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "CinematographyGenres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cinematography_Directors_DirectorID",
                        column: x => x.DirectorID,
                        principalTable: "Directors",
                        principalColumn: "DirectorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors_Cinematography",
                columns: table => new
                {
                    ActorID = table.Column<int>(type: "int", nullable: false),
                    CinematographyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors_Cinematography", x => new { x.ActorID, x.CinematographyID });
                    table.ForeignKey(
                        name: "FK_Actors_Cinematography_Actors_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actors_Cinematography_Cinematography_CinematographyID",
                        column: x => x.CinematographyID,
                        principalTable: "Cinematography",
                        principalColumn: "CinematographyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CinematographyCategories_Cinematography",
                columns: table => new
                {
                    CinematographyCategoryID = table.Column<int>(type: "int", nullable: false),
                    CinematographyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinematographyCategories_Cinematography", x => new { x.CinematographyCategoryID, x.CinematographyID });
                    table.ForeignKey(
                        name: "FK_CinematographyCategories_Cinematography_Cinematography_CinematographyID",
                        column: x => x.CinematographyID,
                        principalTable: "Cinematography",
                        principalColumn: "CinematographyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CinematographyCategories_Cinematography_CinematographyCategories_CinematographyCategoryID",
                        column: x => x.CinematographyCategoryID,
                        principalTable: "CinematographyCategories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Writers_Cinematographys",
                columns: table => new
                {
                    WriterID = table.Column<int>(type: "int", nullable: false),
                    CinematographyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers_Cinematographys", x => new { x.WriterID, x.CinematographyID });
                    table.ForeignKey(
                        name: "FK_Writers_Cinematographys_Cinematography_CinematographyID",
                        column: x => x.CinematographyID,
                        principalTable: "Cinematography",
                        principalColumn: "CinematographyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Writers_Cinematographys_Writers_WriterID",
                        column: x => x.WriterID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Cinematography_CinematographyID",
                table: "Actors_Cinematography",
                column: "CinematographyID");

            migrationBuilder.CreateIndex(
                name: "IX_Cinematography_DirectorID",
                table: "Cinematography",
                column: "DirectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Cinematography_GenreID",
                table: "Cinematography",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_CinematographyCategories_Cinematography_CinematographyID",
                table: "CinematographyCategories_Cinematography",
                column: "CinematographyID");

            migrationBuilder.CreateIndex(
                name: "IX_Writers_Cinematographys_CinematographyID",
                table: "Writers_Cinematographys",
                column: "CinematographyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors_Cinematography");

            migrationBuilder.DropTable(
                name: "CinematographyCategories_Cinematography");

            migrationBuilder.DropTable(
                name: "Writers_Cinematographys");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "CinematographyCategories");

            migrationBuilder.DropTable(
                name: "Cinematography");

            migrationBuilder.DropTable(
                name: "Writers");

            migrationBuilder.DropTable(
                name: "CinematographyGenres");

            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
