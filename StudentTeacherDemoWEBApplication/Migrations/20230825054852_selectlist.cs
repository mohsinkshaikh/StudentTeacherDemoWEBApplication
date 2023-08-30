using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentTeacherDemoWEBApplication.Migrations
{
    /// <inheritdoc />
    public partial class selectlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_product_tbl_category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "tbl_category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_product_CategoryID",
                table: "tbl_product",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_product");

            migrationBuilder.DropTable(
                name: "tbl_category");
        }
    }
}
