using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GUIProject.Migrations
{
    /// <inheritdoc />
    public partial class initail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Module1 = table.Column<double>(type: "REAL", nullable: false),
                    Module2 = table.Column<double>(type: "REAL", nullable: false),
                    Module3 = table.Column<double>(type: "REAL", nullable: false),
                    Module4 = table.Column<double>(type: "REAL", nullable: false),
                    Module5 = table.Column<double>(type: "REAL", nullable: false),
                    Module6 = table.Column<double>(type: "REAL", nullable: false),
                    Module7 = table.Column<double>(type: "REAL", nullable: false),
                    Module8 = table.Column<double>(type: "REAL", nullable: false),
                    GPA = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Pasword = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
