using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeoplesAndCats.Migrations
{
    /// <inheritdoc />
    public partial class Modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeopeId",
                table: "Cats");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeopeId",
                table: "Cats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
