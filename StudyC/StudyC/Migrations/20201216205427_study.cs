using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyC.Migrations
{
    public partial class study : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    Mobile = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(maxLength: 50, nullable: false),
                    Message = table.Column<string>(maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Study",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(maxLength: 300, nullable: false),
                    Information = table.Column<string>(maxLength: 20000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<int>(nullable: false),
                    Mail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrectAnswer = table.Column<int>(nullable: false),
                    Questions = table.Column<string>(maxLength: 500, nullable: false),
                    NumOfOptions = table.Column<int>(nullable: false),
                    StudyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Study_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserStudy",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    StudyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStudy", x => new { x.UserId, x.StudyId });
                    table.ForeignKey(
                        name: "FK_UserStudy_Study_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserStudy_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_StudyId",
                table: "Question",
                column: "StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserStudy_StudyId",
                table: "UserStudy",
                column: "StudyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "UserStudy");

            migrationBuilder.DropTable(
                name: "Study");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
