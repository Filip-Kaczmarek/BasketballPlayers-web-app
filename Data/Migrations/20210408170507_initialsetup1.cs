using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketballPlayers.Data.Migrations
{
    public partial class initialsetup1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Player",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Player",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Player",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Player",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Player",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "Player",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "Surname",
                table: "Player",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Player",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
