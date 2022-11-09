using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace JobManagementLibrary.DataAccess
{
    public partial class JobManagementContext : DbContext
    {
        public JobManagementContext()
        {
        }

        public JobManagementContext(DbContextOptions<JobManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CandidateProfile> CandidateProfiles { get; set; } = null!;
        public virtual DbSet<Hraccount> Hraccounts { get; set; } = null!;
        public virtual DbSet<JobPosting> JobPostings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();
                string connectionString = configuration.GetConnectionString("MyStoreDB");
                optionsBuilder.UseSqlServer(connectionString);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidateProfile>(entity =>
            {
                entity.HasKey(e => e.CandidateId);

                entity.ToTable("CandidateProfile");

                entity.Property(e => e.CandidateId)
                    .ValueGeneratedNever()
                    .HasColumnName("CandidateID");

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.PostingId).HasColumnName("PostingID");

                entity.Property(e => e.ProfileShortDescription).HasColumnType("text");

                entity.Property(e => e.ProfileUrl)
                    .HasMaxLength(50)
                    .HasColumnName("ProfileURL");

                entity.HasOne(d => d.Posting)
                    .WithMany(p => p.CandidateProfiles)
                    .HasForeignKey(d => d.PostingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidateProfile_JobPosting");
            });

            modelBuilder.Entity<Hraccount>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("HRAccount");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<JobPosting>(entity =>
            {
                entity.HasKey(e => e.PostingId);

                entity.ToTable("JobPosting");

                entity.Property(e => e.PostingId)
                    .ValueGeneratedNever()
                    .HasColumnName("PostingID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.JobPostingTitle).HasMaxLength(50);

                entity.Property(e => e.PostedDate).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
