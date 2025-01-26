using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeLance.Migrations
{
    public partial class Freelance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FreelanceUsers",
                columns: table => new
                {
                    UId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelanceUsers", x => x.UId);
                });

            migrationBuilder.CreateTable(
                name: "UHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UId = table.Column<int>(type: "int", nullable: false),
                    FreelanceUserUId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UHobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UHobbies_FreelanceUsers_FreelanceUserUId",
                        column: x => x.FreelanceUserUId,
                        principalTable: "FreelanceUsers",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USkillsets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UId = table.Column<int>(type: "int", nullable: false),
                    FreelanceUserUId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USkillsets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_USkillsets_FreelanceUsers_FreelanceUserUId",
                        column: x => x.FreelanceUserUId,
                        principalTable: "FreelanceUsers",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UHobbies_FreelanceUserUId",
                table: "UHobbies",
                column: "FreelanceUserUId");

            migrationBuilder.CreateIndex(
                name: "IX_USkillsets_FreelanceUserUId",
                table: "USkillsets",
                column: "FreelanceUserUId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UHobbies");

            migrationBuilder.DropTable(
                name: "USkillsets");

            migrationBuilder.DropTable(
                name: "FreelanceUsers");
        }
    }
}
