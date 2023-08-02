using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Novin.FoodApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuRestaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAppetizer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppetizerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppetizerPrice = table.Column<double>(type: "float", nullable: false),
                    TitleMainDish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionMainDish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainDishPrice = table.Column<double>(type: "float", nullable: false),
                    TitleDessert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionDessert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DessertPrice = table.Column<double>(type: "float", nullable: true),
                    TitleDrink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrinkPrice = table.Column<double>(type: "float", nullable: true),
                    TitleSideDishes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SideDishesPrice = table.Column<double>(type: "float", nullable: false),
                    MenuUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRestaurants", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRestaurants");
        }
    }
}
