using Microsoft.EntityFrameworkCore;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Persistence
{
    public class SelfAssessmentDbContext:DbContext
    {
        public SelfAssessmentDbContext(DbContextOptions<SelfAssessmentDbContext>options):base(options)
        {

        }
        public DbSet<Taxpayer> Taxpayer { get; set; } 
        public DbSet<State> State { get; set; }
        public DbSet<Lga> Lga { get; set; }
        public DbSet<Town> Town { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }
        public DbSet<ViewPayerInfo> ViewPayerInfo { get; set; }
        public DbSet<BusinessOwnship> BusinessOwnship { get; set; }
        public DbSet<BusinessSubClass> BusinessSubClass { get; set; }
        public DbSet<BusinessType> BusinessType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TaxAgent>()
            .HasNoKey();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Taxpayer>()
            .HasNoKey();
            modelBuilder.Entity<BusinessType>()
            .HasNoKey();
            modelBuilder.Entity<BusinessSubClass>()
            .HasNoKey();
            modelBuilder.Entity<BusinessOwnship>()
            .HasNoKey();

            modelBuilder.Entity<ViewPayerInfo>()
            .HasNoKey();
            modelBuilder.Entity<MaritalStatus>()
            .HasNoKey();
        
        }
    }
}
