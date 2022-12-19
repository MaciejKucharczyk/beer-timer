using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace beer_timer.Migrations
{
    public partial class beerContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ranking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Sec = table.Column<int>(type: "int", nullable: true),
                    Tens = table.Column<int>(type: "int", nullable: true),
                    UserName_Id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Technique = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranking", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ranking");
        }
    }
}
