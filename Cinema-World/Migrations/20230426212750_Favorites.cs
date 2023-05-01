using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema_World.Migrations
{
    public partial class Favorites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUserCinematography",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CinematographyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserCinematography", x => new { x.UserID, x.CinematographyID });
                    table.ForeignKey(
                        name: "FK_AspNetUserCinematography_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserCinematography_Cinematography_CinematographyID",
                        column: x => x.CinematographyID,
                        principalTable: "Cinematography",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserCinematography_CinematographyID",
                table: "AspNetUserCinematography",
                column: "CinematographyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserCinematography");
        }
    }
}
