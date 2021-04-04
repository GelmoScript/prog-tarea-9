using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorHostingTest.Migrations
{
    public partial class UserInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[,]
                {
                    { 1, "Gojo", "Satoru" },
                    { 2, "Itadori", "Yuji" },
                    { 3, "Fushiguro", "Megumi" },
                    { 4, "Kugisaki", "Nobara" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
