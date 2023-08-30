using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentTeacherDemoWEBApplication.Migrations
{
    /// <inheritdoc />
    public partial class dd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GraduationPostGraduation");

            migrationBuilder.AddColumn<int>(
                name: "PostGraduationPostID",
                table: "tbl_graduation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_graduation_PostGraduationPostID",
                table: "tbl_graduation",
                column: "PostGraduationPostID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_graduation_tbl_post_graduation_PostGraduationPostID",
                table: "tbl_graduation",
                column: "PostGraduationPostID",
                principalTable: "tbl_post_graduation",
                principalColumn: "PostID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_graduation_tbl_post_graduation_PostGraduationPostID",
                table: "tbl_graduation");

            migrationBuilder.DropIndex(
                name: "IX_tbl_graduation_PostGraduationPostID",
                table: "tbl_graduation");

            migrationBuilder.DropColumn(
                name: "PostGraduationPostID",
                table: "tbl_graduation");

            migrationBuilder.CreateTable(
                name: "GraduationPostGraduation",
                columns: table => new
                {
                    PostGradPostID = table.Column<int>(type: "int", nullable: false),
                    graduationGradID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraduationPostGraduation", x => new { x.PostGradPostID, x.graduationGradID });
                    table.ForeignKey(
                        name: "FK_GraduationPostGraduation_tbl_graduation_graduationGradID",
                        column: x => x.graduationGradID,
                        principalTable: "tbl_graduation",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GraduationPostGraduation_tbl_post_graduation_PostGradPostID",
                        column: x => x.PostGradPostID,
                        principalTable: "tbl_post_graduation",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GraduationPostGraduation_graduationGradID",
                table: "GraduationPostGraduation",
                column: "graduationGradID");
        }
    }
}
