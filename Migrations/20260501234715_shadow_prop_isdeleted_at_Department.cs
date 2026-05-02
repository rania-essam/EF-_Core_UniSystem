using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFday1_UniversitySystem.Migrations
{
    /// <inheritdoc />
    public partial class shadow_prop_isdeleted_at_Department : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Is_Deleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_Deleted",
                table: "Departments");
        }
    }
}
