using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_JqGrid.Models
{
    public class PupilContext:DbContext
    {
        public PupilContext():base("Pupil")
        { }
        public DbSet<Pupil> Novices { get; set; }
        public DbSet<PupilDetail> NoviceDetails { get; set; }

        public DbSet<ViewModel> ViewModels { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Test");

            // Configure NoviceId as PK for NoviceDetail
            modelBuilder.Entity<PupilDetail>()
                .HasKey(e => e.PupilId);

            // Configure NoviceId as FK for NoviceDetail
            modelBuilder.Entity<Pupil>()
                        .HasRequired(s => s.PupilDetail)
                        .WithRequiredPrincipal(ad => ad.Pupil);

        }




    }
}