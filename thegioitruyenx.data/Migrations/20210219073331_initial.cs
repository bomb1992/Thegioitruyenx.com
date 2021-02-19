using Microsoft.EntityFrameworkCore.Migrations;

namespace thegioitruyenx.data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SortOder = table.Column<int>(nullable: false),
                    IsShowOnHome = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Stock = table.Column<int>(nullable: false, defaultValue: 0),
                    ViewCout = table.Column<int>(nullable: false, defaultValue: 0),
                    DateCreate = table.Column<string>(nullable: true),
                    SeoAlias = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThegioitruyenxAppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThegioitruyenxAppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCategories", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "Name", "ParentId", "SortOder", "Status" },
                values: new object[,]
                {
                    { 1, true, "Áo", null, 1, 1 },
                    { 2, true, "Quần", null, 1, 1 },
                    { 3, true, "Giày", null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreate", "Name", "OriginalPrice", "Price", "SeoAlias", "Stock" },
                values: new object[,]
                {
                    { 1990, null, "Áo thun", 7000m, 10000m, null, 10 },
                    { 1991, null, "Quần thun", 15000m, 20000m, null, 20 },
                    { 1992, null, "Quần Tây", 20000m, 30000m, null, 20 }
                });

            migrationBuilder.InsertData(
                table: "ThegioitruyenxAppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of thegioitruyenx.com" },
                    { "HomeKeywork", "This is keywork page of thegioitruyenx.com" },
                    { "HomeDescription", "This is description of thegioitruyenx.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_ProductId",
                table: "ProductInCategories",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInCategories");

            migrationBuilder.DropTable(
                name: "ThegioitruyenxAppConfigs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
