using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema_World.Migrations
{
    public partial class uploadTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UploadTime",
                table: "AspNetUserCinematography",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UploadTime",
                table: "AspNetUserCinematography");
        }
    }
}
