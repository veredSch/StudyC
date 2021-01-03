using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyC.Migrations
{
    public partial class options_fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "NumOfOptions",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "Question");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Question",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "Option",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "Option");

            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswer",
                table: "Question",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfOptions",
                table: "Question",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "Question",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
