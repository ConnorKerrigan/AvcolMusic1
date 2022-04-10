using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AvcolMusic1.Migrations
{
    public partial class DbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.CreateTable(
            //        name: "Student",
            //        columns: table => new
            //        {
            //            StudentID = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            Year = table.Column<int>(type: "int", nullable: false),
            //            HomeRoom = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Student", x => x.StudentID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Teacher",
            //        columns: table => new
            //        {
            //            TeacherID = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Teacher", x => x.TeacherID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Class",
            //        columns: table => new
            //        {
            //            ClassID = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            StudentID = table.Column<int>(type: "int", nullable: false),
            //            TeacherID = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //            Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //            StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
            //            EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Class", x => x.ClassID);
            //            table.ForeignKey(
            //                name: "FK_Class_Student_StudentID",
            //                column: x => x.StudentID,
            //                principalTable: "Student",
            //                principalColumn: "StudentID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_Class_Teacher_TeacherID",
            //                column: x => x.TeacherID,
            //                principalTable: "Teacher",
            //                principalColumn: "TeacherID",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Group",
            //        columns: table => new
            //        {
            //            GroupID = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            TeacherID = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //            Instrument = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            Room = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //            Day = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Group", x => x.GroupID);
            //            table.ForeignKey(
            //                name: "FK_Group_Teacher_TeacherID",
            //                column: x => x.TeacherID,
            //                principalTable: "Teacher",
            //                principalColumn: "TeacherID",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Lesson",
            //        columns: table => new
            //        {
            //            LessonID = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            GroupID = table.Column<int>(type: "int", nullable: false),
            //            Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //            StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
            //            EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Lesson", x => x.LessonID);
            //            table.ForeignKey(
            //                name: "FK_Lesson_Group_GroupID",
            //                column: x => x.GroupID,
            //                principalTable: "Group",
            //                principalColumn: "GroupID",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "MusicTimetable",
            //        columns: table => new
            //        {
            //            MusicTimetableID = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            StudentID = table.Column<int>(type: "int", nullable: false),
            //            GroupID = table.Column<int>(type: "int", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_MusicTimetable", x => x.MusicTimetableID);
            //            table.ForeignKey(
            //                name: "FK_MusicTimetable_Group_GroupID",
            //                column: x => x.GroupID,
            //                principalTable: "Group",
            //                principalColumn: "GroupID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_MusicTimetable_Student_StudentID",
            //                column: x => x.StudentID,
            //                principalTable: "Student",
            //                principalColumn: "StudentID",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Class_StudentID",
            //        table: "Class",
            //        column: "StudentID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Class_TeacherID",
            //        table: "Class",
            //        column: "TeacherID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Group_TeacherID",
            //        table: "Group",
            //        column: "TeacherID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Lesson_GroupID",
            //        table: "Lesson",
            //        column: "GroupID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MusicTimetable_GroupID",
            //        table: "MusicTimetable",
            //        column: "GroupID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MusicTimetable_StudentID",
            //        table: "MusicTimetable",
            //        column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "MusicTimetable");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
