using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoAluno.Models
{
    public partial class AlunoDB : DbContext
    {
        public AlunoDB()
        {
        }

        public AlunoDB(DbContextOptions<AlunoDB> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAluno> TbAluno { get; set; }
        public virtual DbSet<TbCurso> TbCurso { get; set; }
        public virtual DbSet<TbGradeCurricular> TbGradeCurricular { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=remotemysql.com;user id=ZzyYHTbz1s;password=sCBZ4ktYVy;database=ZzyYHTbz1s", x => x.ServerVersion("8.0.13-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAluno>(entity =>
            {
                entity.HasKey(e => e.IdAluno)
                    .HasName("PRIMARY");

                entity.Property(e => e.NmAluno)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.NmTurma)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<TbCurso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PRIMARY");

                entity.Property(e => e.NmCurso)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TpCurso)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<TbGradeCurricular>(entity =>
            {
                entity.HasKey(e => e.IdGradeCurricular)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdGradeCurricular).ValueGeneratedNever();

                entity.Property(e => e.NmMateria)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.NmProfessor)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
