using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentTeacherDemoWEBApplication.Migrations
{
    /// <inheritdoc />
    public partial class GP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_country",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_country", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_course",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseFee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_course", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_post_graduation",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_post_graduation", x => x.PostID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_student",
                columns: table => new
                {
                    STUD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderRadio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderEnum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Taluka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enrolled = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_student", x => x.STUD_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_teacher",
                columns: table => new
                {
                    TID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_teacher", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_state",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_state", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_state_tbl_country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "tbl_country",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_graduation",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostGraduationPostID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_graduation", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_tbl_graduation_tbl_post_graduation_PostGraduationPostID",
                        column: x => x.PostGraduationPostID,
                        principalTable: "tbl_post_graduation",
                        principalColumn: "PostID");
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    ID_SC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentsSTUD_ID = table.Column<int>(type: "int", nullable: false),
                    CoursesCourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => x.ID_SC);
                    table.ForeignKey(
                        name: "FK_StudentCourse_tbl_course_CoursesCourseID",
                        column: x => x.CoursesCourseID,
                        principalTable: "tbl_course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_tbl_student_StudentsSTUD_ID",
                        column: x => x.StudentsSTUD_ID,
                        principalTable: "tbl_student",
                        principalColumn: "STUD_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_city",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_city", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_city_tbl_state_StateID",
                        column: x => x.StateID,
                        principalTable: "tbl_state",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CoursesCourseID",
                table: "StudentCourse",
                column: "CoursesCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentsSTUD_ID",
                table: "StudentCourse",
                column: "StudentsSTUD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_city_StateID",
                table: "tbl_city",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_graduation_PostGraduationPostID",
                table: "tbl_graduation",
                column: "PostGraduationPostID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_state_CountryID",
                table: "tbl_state",
                column: "CountryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "tbl_city");

            migrationBuilder.DropTable(
                name: "tbl_graduation");

            migrationBuilder.DropTable(
                name: "tbl_teacher");

            migrationBuilder.DropTable(
                name: "tbl_course");

            migrationBuilder.DropTable(
                name: "tbl_student");

            migrationBuilder.DropTable(
                name: "tbl_state");

            migrationBuilder.DropTable(
                name: "tbl_post_graduation");

            migrationBuilder.DropTable(
                name: "tbl_country");
        }
    }
}
