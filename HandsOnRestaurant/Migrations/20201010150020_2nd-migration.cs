using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnRestaurant.Migrations
{
    public partial class _2ndmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryID",
                table: "Products",
                column: "ProductCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryID",
                table: "Products",
                column: "ProductCategoryID",
                principalTable: "ProductCategories",
                principalColumn: "ProductCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryID",
                table: "Products");
        }
    }
}
