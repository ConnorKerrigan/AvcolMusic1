using AvcolMusic1.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AvcolMusic1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MusicContext context)
        {
            context.Database.EnsureCreated();

            if (context.Student.Any())
            {
                return;   
            }

            //var students = new Student[]
            //{
            //        new Student{StudentID="AC111484",FirstName="Connor",Surname="Kerrigan",Year=12,HomeRoom="LGR"},
            //        new Student{StudentID="AC111888",FirstName="Joe",Surname="Bloggs",Year=11,HomeRoom="DYL"},
            //        new Student{StudentID="AC112542",FirstName="Bruh",Surname="Moment",Year=13,HomeRoom="MAY"},
            //};
            //foreach (Student s in students)
            //{
            //    context.Student.Add(s);
            //}
            //context.SaveChanges();

            var teachers = new Teacher[]
            {
                    new Teacher{TeacherID="LGR",Surname="Longmuir",Firstname="Something"},
                    new Teacher{TeacherID="AGN",Surname="Augustin",Firstname="Gemma"},
                    new Teacher{TeacherID="MAY",Surname="May",Firstname="Mister"},
                    new Teacher{TeacherID="DYL",Surname="Dayal",Firstname="Vishnu"},
                    new Teacher{TeacherID="RBN",Surname="Robinson",Firstname="Michael"},
                    new Teacher{TeacherID="SRN",Surname="Sorensen",Firstname="Fredda"},
            };
            foreach (Teacher t in teachers)
            {
                context.Teacher.Add(t);
            }
            context.SaveChanges();

            //var classes = new Class[]
            //{
            //        new Class{ClassID=0,StudentID="AC111484",TeacherID="AGN",Date=DateTime.Parse("2022-03-30"),StartTime = TimeSpan.Parse("10:15"),EndTime=TimeSpan.Parse("11:14")},
            //        new Class{ClassID=1,StudentID="AC111888",TeacherID="AGN",Date=DateTime.Parse("2022-03-30"),StartTime = TimeSpan.Parse("10:15"),EndTime=TimeSpan.Parse("11:14")},
            //        new Class{ClassID=2,StudentID="AC111484",TeacherID="RBN",Date=DateTime.Parse("2022-03-30"),StartTime = TimeSpan.Parse("09:15"),EndTime=TimeSpan.Parse("10:14")},
            //        new Class{ClassID=3,StudentID="AC112542",TeacherID="MAY",Date=DateTime.Parse("2022-03-30"),StartTime = TimeSpan.Parse("10:15"),EndTime=TimeSpan.Parse("11:14")},
            //        new Class{ClassID=4,StudentID="AC112542",TeacherID="AGN",Date=DateTime.Parse("2022-03-30"),StartTime = TimeSpan.Parse("09:15"),EndTime=TimeSpan.Parse("10:14")},
            //        new Class{ClassID=5,StudentID="AC111484",TeacherID="LGR",Date=DateTime.Parse("2022-03-30"),StartTime = TimeSpan.Parse("11:30"),EndTime=TimeSpan.Parse("12:30")},
            //};
            //foreach (Class c in classes)
            //{
            //    context.Class.Add(c);
            //}
            //context.SaveChanges();

            //var lessons = new Lesson[]
            //{
            //        new Lesson{LessonID=0,GroupID=0,Date = DateTime.Parse("2022-03-30"),StartTime=TimeSpan.Parse("11:30"),EndTime=TimeSpan.Parse("11:59")},
            //        new Lesson{LessonID=1,GroupID=1,Date = DateTime.Parse("2022-03-30"),StartTime=TimeSpan.Parse("11:00"),EndTime=TimeSpan.Parse("11:29")},
            //        new Lesson{LessonID=2,GroupID=2,Date = DateTime.Parse("2022-03-30"),StartTime=TimeSpan.Parse("09:30"),EndTime=TimeSpan.Parse("09:59")},
            //        new Lesson{LessonID=3,GroupID=3,Date = DateTime.Parse("2022-03-30"),StartTime=TimeSpan.Parse("12:00"),EndTime=TimeSpan.Parse("12:29")},
            //};
            //foreach (Lesson l in lessons)
            //{
            //    context.Lesson.Add(l);
            //}
            //context.SaveChanges();

            //var groups = new Group[]
            //{
            //        new Group{GroupID=0,TeacherID="RBN",Instrument="Guitar",Room="A.1",Day="Wednesday"},
            //        new Group{GroupID=1,TeacherID="SCR",Instrument="Piano",Room="A.4",Day="Wednesday"},
            //        new Group{GroupID=2,TeacherID="RBN",Instrument="Piano",Room="A.1",Day="Wednesday"},
            //        new Group{GroupID=3,TeacherID="DYL",Instrument="Guitar",Room="D23",Day="Wednesday"}
            //};
            //foreach (Group g in groups)
            //{
            //    context.Group.Add(g);
            //}
            //context.SaveChanges();

            //var MusicTimetables = new MusicTimetable[]
            //{
            //        new MusicTimetable{MusicTimetableID=0,StudentID="AC112542",GroupID=3},
            //        new MusicTimetable{MusicTimetableID=1,StudentID="AC111484",GroupID=3},
            //        new MusicTimetable{MusicTimetableID=2,StudentID="AC112542",GroupID=1},
            //        new MusicTimetable{MusicTimetableID=3, StudentID="AC111888",GroupID=2},
            //        new MusicTimetable{MusicTimetableID=4, StudentID="AC111888",GroupID=0},
            //        new MusicTimetable{MusicTimetableID=5, StudentID="AC111484",GroupID=0}
            //};
            //foreach (MusicTimetable m in MusicTimetables)
            //{
            //    context.MusicTimetable.Add(m);
            //}
            //context.SaveChanges();
        }
    }
}
