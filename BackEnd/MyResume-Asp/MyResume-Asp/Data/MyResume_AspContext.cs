using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyResume_Asp.Models;

namespace MyResume_Asp.Data
{
    public class MyResume_AspContext : DbContext
    {
        public MyResume_AspContext (DbContextOptions<MyResume_AspContext> options)
            : base(options)
        {
        }

        public DbSet<MyResume_Asp.Models.MyInformation> MyInformation { get; set; }
        public DbSet<MyResume_Asp.Models.AboutMe> AboutMe { get; set; }
        public DbSet<MyResume_Asp.Models.Facts> Facts { get; set; }
        public DbSet<MyResume_Asp.Models.Resume> Resume { get; set; }
        public DbSet<MyResume_Asp.Models.ResumeSection> ResumeSection { get; set; }
        public DbSet<MyResume_Asp.Models.MySkills> MySkills { get; set; }
        public DbSet<MyResume_Asp.Models.Skill> Skill { get; set; }
    }
}
