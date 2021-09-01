using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ClientSystemDBContext:DbContext
    {
        public ClientSystemDBContext(DbContextOptions<ClientSystemDBContext> options) : base(options)
        {

        }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>(ConfigureClient);
            modelBuilder.Entity<Employees>(ConfigureEmployee);
            modelBuilder.Entity<Interaction>(ConfugureInteraction);
        }
        private void ConfigureClient(EntityTypeBuilder<Clients> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.Phones).HasMaxLength(30);
            builder.Property(c => c.Address).HasMaxLength(100);
            builder.Property(c => c.AddedOn).HasDefaultValueSql("getdate()");

        }
        private void ConfigureEmployee(EntityTypeBuilder<Employees> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.Password).HasMaxLength(10);
            builder.Property(e => e.Designation).HasMaxLength(50);
        }
        private void ConfugureInteraction(EntityTypeBuilder<Interaction> builder)
        {
            builder.ToTable("Interactions");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.IntType).HasMaxLength(1);
            builder.Property(c => c.Remarks).HasMaxLength(500);
            builder.Property(c => c.IntDate).HasDefaultValueSql("getdate()");
            builder.HasOne(c => c.Employee).WithMany(c => c.Interactions).HasForeignKey(c => c.EmpId);
            builder.HasOne(c => c.Client).WithMany(c => c.Interactions).HasForeignKey(c => c.ClientId );
        }

        }
}
