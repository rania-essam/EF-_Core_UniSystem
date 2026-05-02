using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFday1_UniversitySystem.Migrations
{
    /// <inheritdoc />
    public partial class add_shadowproperty_toallentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Is_Deleted",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Deleted",
                table: "Instructors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Deleted",
                table: "Enrollments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Is_Deleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "Is_Deleted",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_Deleted",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Is_Deleted",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Is_Deleted",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Is_Deleted",
                table: "Courses");

            migrationBuilder.AlterColumn<bool>(
                name: "Is_Deleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);
        }
    }
}
