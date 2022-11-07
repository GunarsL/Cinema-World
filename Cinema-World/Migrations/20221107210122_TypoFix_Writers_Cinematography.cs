using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema_World.Migrations
{
    public partial class TypoFix_Writers_Cinematography : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Cinematographys_Cinematography_CinematographyID",
                table: "Writers_Cinematographys");

            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Cinematographys_Writers_WriterID",
                table: "Writers_Cinematographys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Writers_Cinematographys",
                table: "Writers_Cinematographys");

            migrationBuilder.RenameTable(
                name: "Writers_Cinematographys",
                newName: "Writers_Cinematography");

            migrationBuilder.RenameIndex(
                name: "IX_Writers_Cinematographys_CinematographyID",
                table: "Writers_Cinematography",
                newName: "IX_Writers_Cinematography_CinematographyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writers_Cinematography",
                table: "Writers_Cinematography",
                columns: new[] { "WriterID", "CinematographyID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Cinematography_Cinematography_CinematographyID",
                table: "Writers_Cinematography",
                column: "CinematographyID",
                principalTable: "Cinematography",
                principalColumn: "CinematographyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Cinematography_Writers_WriterID",
                table: "Writers_Cinematography",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Cinematography_Cinematography_CinematographyID",
                table: "Writers_Cinematography");

            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Cinematography_Writers_WriterID",
                table: "Writers_Cinematography");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Writers_Cinematography",
                table: "Writers_Cinematography");

            migrationBuilder.RenameTable(
                name: "Writers_Cinematography",
                newName: "Writers_Cinematographys");

            migrationBuilder.RenameIndex(
                name: "IX_Writers_Cinematography_CinematographyID",
                table: "Writers_Cinematographys",
                newName: "IX_Writers_Cinematographys_CinematographyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writers_Cinematographys",
                table: "Writers_Cinematographys",
                columns: new[] { "WriterID", "CinematographyID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Cinematographys_Cinematography_CinematographyID",
                table: "Writers_Cinematographys",
                column: "CinematographyID",
                principalTable: "Cinematography",
                principalColumn: "CinematographyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Cinematographys_Writers_WriterID",
                table: "Writers_Cinematographys",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
