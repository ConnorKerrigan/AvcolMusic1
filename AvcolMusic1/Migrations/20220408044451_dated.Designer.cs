﻿// <auto-generated />
using System;
using AvcolMusic1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AvcolMusic1.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20220408044451_dated")]
    partial class dated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvcolMusic1.Models.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<string>("TeacherID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ClassID");

                    b.HasIndex("StudentID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instrument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GroupID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Lesson", b =>
                {
                    b.Property<int>("LessonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("LessonID");

                    b.HasIndex("GroupID");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("AvcolMusic1.Models.MusicTimetable", b =>
                {
                    b.Property<int>("MusicTimetableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("MusicTimetableID");

                    b.HasIndex("GroupID");

                    b.HasIndex("StudentID");

                    b.ToTable("MusicTimetable");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeRoom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Teacher", b =>
                {
                    b.Property<string>("TeacherID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Class", b =>
                {
                    b.HasOne("AvcolMusic1.Models.Student", "Student")
                        .WithMany("Classes")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvcolMusic1.Models.Teacher", "Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherID");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Group", b =>
                {
                    b.HasOne("AvcolMusic1.Models.Teacher", "Teacher")
                        .WithMany("Groups")
                        .HasForeignKey("TeacherID");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Lesson", b =>
                {
                    b.HasOne("AvcolMusic1.Models.Group", "Group")
                        .WithMany("Lessons")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("AvcolMusic1.Models.MusicTimetable", b =>
                {
                    b.HasOne("AvcolMusic1.Models.Group", "Group")
                        .WithMany("MusicTimetables")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvcolMusic1.Models.Student", "Student")
                        .WithMany("MusicTimetables")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Group", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("MusicTimetables");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Student", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("MusicTimetables");
                });

            modelBuilder.Entity("AvcolMusic1.Models.Teacher", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
