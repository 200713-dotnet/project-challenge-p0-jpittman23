using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaStore.Storing
{
    public partial class PizzadbContext : DbContext
    {
        public PizzadbContext()
        {
        }

        public PizzadbContext(DbContextOptions<PizzadbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Crust> Crust { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<PizzaTopping> PizzaTopping { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Topping> Topping { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;database=Pizzadb;user id=sa;password=Jocelynn23");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crust>(entity =>
            {
                entity.ToTable("Crust", "Pizzas");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("Pizza", "Pizzas");

                entity.Property(e => e.DateModified).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsValid)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Crust)
                    .WithMany(p => p.Pizza)
                    .HasForeignKey(d => d.CrustId)
                    .HasConstraintName("FK_CrustId");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Pizza)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_SizeId");
            });

            modelBuilder.Entity<PizzaTopping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PizzaTopping", "Pizzas");

                entity.Property(e => e.PizzaToppingId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Pizza)
                    .WithMany()
                    .HasForeignKey(d => d.PizzaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PizzaId");

                entity.HasOne(d => d.Topping)
                    .WithMany()
                    .HasForeignKey(d => d.ToppingId)
                    .HasConstraintName("FK_ToppingId");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size", "Pizzas");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store", "Pizzas");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Topping>(entity =>
            {
                entity.ToTable("Topping", "Pizzas");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_UsersID");

                entity.ToTable("Users", "Pizzas");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
