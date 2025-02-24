using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using BenefitUploader.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BenefitUploader.Models
{
    public partial class DbBenefitUploaderContext : DbContext
    {
        private readonly MySetting mySetting;
        public DbBenefitUploaderContext()
        {
        }

        public DbBenefitUploaderContext(DbContextOptions<DbBenefitUploaderContext> options, IOptions<MySetting> mySetting)
            : base(options)
        {
            this.mySetting = mySetting.Value;
        }

        public IConfiguration Configuration { get; }

        //private const string PREFIX = "BenefitUploader_";

        public virtual DbSet<Benefit> Benefits { get; set; }
        public virtual DbSet<LoanMedical> LoanMedicals { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(this.mySetting.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Benefit>(entity =>
            {
                entity.ToTable("benefit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeID)
                    .HasColumnName("employeeid")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersArea)
                    .HasColumnName("pers_area")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CutOffDate)
                    .HasColumnName("cut_off_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LimitTahunan)
                    .HasColumnName("limit_tahunan")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KlaimDibayar)
                    .HasColumnName("klaim_dibayar")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.OverPlafon)
                  .HasColumnName("over_plafon")
                  .HasMaxLength(100)
                  .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                   .HasColumnName("description")
                   .HasMaxLength(1)
                   .IsUnicode(false);


                entity.Property(e => e.TahunPerobatan)
                   .HasColumnName("tahun_perobatan")
                   .HasMaxLength(4)
                   .IsUnicode(false);
            });


            modelBuilder.Entity<LoanMedical>(entity =>
            {
                entity.ToTable("loan_medical");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeID)
                    .HasColumnName("employeeid")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pasien)
                    .HasColumnName("pasien")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TglAwalBerobat)
                    .HasColumnName("tgl_awal_berobat")
                    .HasColumnType("datetime");

                entity.Property(e => e.TglAkhirBerobat)
                    .HasColumnName("tgl_akhir_berobat")
                    .HasColumnType("datetime");

                entity.Property(e => e.TempatBerobat)
                    .HasColumnName("tempat_berobat")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JenisKlaim)
                    .HasColumnName("jenis_klaim")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NominalPotongan)
                    .HasColumnName("nominal_potongan")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Biaya)
                    .HasColumnName("biaya")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Angsuran)
                    .HasColumnName("angsuran")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Keterangan)
                    .HasColumnName("keterangan")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodePemotongan)
                    .HasColumnName("periode_mulai_pemotongan")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                   .HasColumnName("description")
                   .HasMaxLength(1)
                   .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("view_employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeID)
                    .HasColumnName("employeeid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdAccount)
                    .HasColumnName("adaccount")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentStatus)
                    .HasColumnName("EmploymentStatus")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                
            });

        }
    }
}
