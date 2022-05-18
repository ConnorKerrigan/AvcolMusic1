using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AvcolMusic1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AvcolMusic1.Data
{
    public class MusicContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
        }

        public DbSet<AvcolMusic1.Models.Group> Group { get; set; }

        public DbSet<AvcolMusic1.Models.Lesson> Lesson { get; set; }

        public DbSet<AvcolMusic1.Models.Teacher> Teacher { get; set; }

        public DbSet<AvcolMusic1.Models.Class> Class { get; set; }

        public DbSet<AvcolMusic1.Models.MusicTimetable> MusicTimetable { get; set; }

        public DbSet<AvcolMusic1.Models.Student> Student { get; set; }
    }
}
