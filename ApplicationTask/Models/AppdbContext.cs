using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApplicationTask.Models;

public partial class AppdbContext : DbContext
{
    public AppdbContext()
    {
    }

    public AppdbContext(DbContextOptions<AppdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Achievement> Achievements { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Applicant> Applicants { get; set; }

    public virtual DbSet<Certification> Certifications { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<FamilyMember> FamilyMembers { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Seminar> Seminars { get; set; }

    public virtual DbSet<TblReference> TblReferences { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PRAJAKTA\\SQLEXPRESS;Database=Appdb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Achievement>(entity =>
        {
            entity.HasKey(e => e.AchievementId).HasName("PK__Achievem__276330C0F115DC20");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.Achievements)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("fkachivkid");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Address__091C2A1B08E384F1");

            entity.ToTable("Address");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HouseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PeriodOfStay)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pincode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("fkaddid");
        });

        modelBuilder.Entity<Applicant>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__Applican__C93A4C99BB0A6407");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Email_Address");
            entity.Property(e => e.FatherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Marital_Status");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PanCardNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Pan_Card_Number");
            entity.Property(e => e.PassportExpireDate).HasColumnName("passport_Expire_Date");
            entity.Property(e => e.PassportIssu).HasColumnName("Passport_Issu");
            entity.Property(e => e.PassportNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.Sex)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SocialSecurityNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Social_Security_Number");
            entity.Property(e => e.VisaStatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Visa_Status");
            entity.Property(e => e.WillingTarvalUsa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Willing_Tarval_USA");
        });

        modelBuilder.Entity<Certification>(entity =>
        {
            entity.HasKey(e => e.CertificateId).HasName("PK__Certific__BBF8A7C172A6E6A6");

            entity.Property(e => e.Division).HasMaxLength(50);
            entity.Property(e => e.Institute)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.Certifications)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("fkcerkid");
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.HasKey(e => e.EdutionId).HasName("PK__Educatio__27E8F69CD5022BF0");

            entity.ToTable("Education");

            entity.Property(e => e.CollegeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Course)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Degree)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Elective)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniversityName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.Educations)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("fkapkid");
        });

        modelBuilder.Entity<FamilyMember>(entity =>
        {
            entity.HasKey(e => e.FamilyMemberId).HasName("PK__FamilyMe__B7AD6DF39D175CFF");

            entity.Property(e => e.FamilyMemberId).HasColumnName("FamilyMemberID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Relationship)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Applicant).WithMany(p => p.FamilyMembers)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("fksd");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK__Language__B938558BF1D60E29");

            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.CanRead)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CanSpeak)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CanWrite)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LanguageName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.Languages)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("fkappid");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__Projects__761ABEF0A1263D82");

            entity.Property(e => e.Client)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Platform)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SkillsUsed)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("fkprokid");
        });

        modelBuilder.Entity<Seminar>(entity =>
        {
            entity.HasKey(e => e.SeminarId).HasName("PK__Seminars__66BB89153E265E76");

            entity.Property(e => e.ConductedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.Seminars)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("fksemirkid");
        });

        modelBuilder.Entity<TblReference>(entity =>
        {
            entity.HasKey(e => e.ReferenceId).HasName("PK__tblRefer__E1A99A19DE6631EF");

            entity.ToTable("tblReference");

            entity.Property(e => e.CurrentCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Application).WithMany(p => p.TblReferences)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("fkrefkid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
