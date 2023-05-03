using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingApp.WebApi.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    DescriptionOfFood = table.Column<string>(type: "varchar(8000)", maxLength: 8000, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    EmailAdd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    PhNo = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    Password = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Favourite",
                columns: table => new
                {
                    FavId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourite", x => x.FavId);
                    table.ForeignKey(
                        name: "FK_Favourite_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_FoodId",
                table: "Favourite",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_UserId",
                table: "Favourite",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourite");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
