﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersId")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("CourseTeacher");
                });

            modelBuilder.Entity("CourseUniversity", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("UniversitiesId")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "UniversitiesId");

                    b.HasIndex("UniversitiesId");

                    b.ToTable("CourseUniversity");
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersId")
                        .HasColumnType("int");

                    b.HasKey("StudentsId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("StudentTeacher");
                });

            modelBuilder.Entity("WebSchoolAPI.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebSchoolAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long>("EGN")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StudentNumber")
                        .HasColumnType("bigint");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebSchoolAPI.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long>("EGN")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("WebSchoolAPI.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("WebSchoolAPI.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebSchoolAPI.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.HasOne("WebSchoolAPI.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebSchoolAPI.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseUniversity", b =>
                {
                    b.HasOne("WebSchoolAPI.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebSchoolAPI.Models.University", null)
                        .WithMany()
                        .HasForeignKey("UniversitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.HasOne("WebSchoolAPI.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebSchoolAPI.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebSchoolAPI.Models.Student", b =>
                {
                    b.HasOne("WebSchoolAPI.Models.University", "University")
                        .WithMany("Students")
                        .HasForeignKey("UniversityId");

                    b.Navigation("University");
                });

            modelBuilder.Entity("WebSchoolAPI.Models.Teacher", b =>
                {
                    b.HasOne("WebSchoolAPI.Models.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId");

                    b.Navigation("University");
                });

            modelBuilder.Entity("WebSchoolAPI.Models.University", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
