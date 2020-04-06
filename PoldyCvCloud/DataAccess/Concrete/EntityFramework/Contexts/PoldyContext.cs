using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class PoldyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=PoldyCv;Trusted_Connection=true");
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<JobAdvertisement> JobAdvertisements { get; set; }
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Apply> Applies { get; set; }
    }
}
