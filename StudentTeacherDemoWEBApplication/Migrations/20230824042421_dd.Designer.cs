﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentTeacherDemoWEBApplication.Data;

#nullable disable

namespace StudentTeacherDemoWEBApplication.Migrations
{
    [DbContext(typeof(StudCourseDBContext))]
    [Migration("20230824042421_dd")]
    partial class dd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StateID");

                    b.ToTable("tbl_city");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("tbl_country");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Courses", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseFee")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("tbl_course");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Graduation", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradID"));

                    b.Property<string>("GradName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostGraduationPostID")
                        .HasColumnType("int");

                    b.HasKey("GradID");

                    b.HasIndex("PostGraduationPostID");

                    b.ToTable("tbl_graduation");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.PostGraduation", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostID"));

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("PostName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostID");

                    b.ToTable("tbl_post_graduation");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.State", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CountryID");

                    b.ToTable("tbl_state");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Student", b =>
                {
                    b.Property<int>("STUD_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("STUD_ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Enrolled")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("GenderEnum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderRadio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Taluka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("STUD_ID");

                    b.ToTable("tbl_student");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.StudentCourse", b =>
                {
                    b.Property<int>("ID_SC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_SC"));

                    b.Property<int>("CoursesCourseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentsSTUD_ID")
                        .HasColumnType("int");

                    b.HasKey("ID_SC");

                    b.HasIndex("CoursesCourseID");

                    b.HasIndex("StudentsSTUD_ID");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Teacher", b =>
                {
                    b.Property<int>("TID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TID"));

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TID");

                    b.ToTable("tbl_teacher");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.City", b =>
                {
                    b.HasOne("StudentTeacherDemoWEBApplication.Models.State", "state")
                        .WithMany("cities")
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("state");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Graduation", b =>
                {
                    b.HasOne("StudentTeacherDemoWEBApplication.Models.PostGraduation", null)
                        .WithMany("graduation")
                        .HasForeignKey("PostGraduationPostID");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.State", b =>
                {
                    b.HasOne("StudentTeacherDemoWEBApplication.Models.Country", "country")
                        .WithMany("states")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentTeacherDemoWEBApplication.Models.Courses", "Courses")
                        .WithMany("StudCourse")
                        .HasForeignKey("CoursesCourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentTeacherDemoWEBApplication.Models.Student", "Students")
                        .WithMany("StudCourse")
                        .HasForeignKey("StudentsSTUD_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Country", b =>
                {
                    b.Navigation("states");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Courses", b =>
                {
                    b.Navigation("StudCourse");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.PostGraduation", b =>
                {
                    b.Navigation("graduation");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.State", b =>
                {
                    b.Navigation("cities");
                });

            modelBuilder.Entity("StudentTeacherDemoWEBApplication.Models.Student", b =>
                {
                    b.Navigation("StudCourse");
                });
#pragma warning restore 612, 618
        }
    }
}
