using Microsoft.EntityFrameworkCore.Migrations;

namespace familycoins.Migrations
{
    public partial class InitialCreateAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FamilyMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyCoinsScore = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeOfTransaction = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: true),
                    points = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FamilyMembers",
                columns: new[] { "Id", "Details", "FamilyCoinsScore", "Name" },
                values: new object[] { 1, "Eric", 500, "Eric" });

            migrationBuilder.InsertData(
                table: "FamilyMembers",
                columns: new[] { "Id", "Details", "FamilyCoinsScore", "Name" },
                values: new object[] { 2, "Adri", 500, "Adri" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Details", "Name", "TypeOfTransaction", "points" },
                values: new object[] { 1, "", "No Hacer Caso", 0, -100 });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Details", "Name", "TypeOfTransaction", "points" },
                values: new object[] { 2, "", "No Hacer Caso 2", 0, -100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FamilyMembers");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
