using API.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        // saver db my sql
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Goods> Goodss { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transport> Transports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");
                entity.HasKey(e => new { e.Id
                    //, e.CustomerId, e.PaymentId, e.TransportId 
                });

                entity.HasOne(e => e.Customers)
                   .WithMany(e => e.Bills)
                   .HasForeignKey(e => e.CustomerId)
                   .HasConstraintName("FK_Bill_Customer");

                entity.HasOne(e => e.Payments)
                   .WithMany(e => e.Bills)
                   .HasForeignKey(e => e.PaymentId)
                   .HasConstraintName("FK_Bill_Payment");

                entity.HasOne(e => e.Transports)
                   .WithMany(e => e.Bills)
                   .HasForeignKey(e => e.TransportId)
                   .HasConstraintName("FK_Bill_Transport");
            });

            modelBuilder.Entity<FeedBack>(entity =>
            {
                entity.ToTable("FeedBack");
                entity.HasKey(e => new { e.Id, e.CustomerId });

                entity.HasOne(e => e.Customer)
                   .WithMany(e => e.FeedBacks)
                   .HasForeignKey(e => e.CustomerId)
                   .HasConstraintName("FK_FeedBack_Customer");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group");
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Goods>(entity =>
            {
                entity.ToTable("Goods");
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.ToTable("InvoiceDetail");
                entity.HasKey(e => new { e.Id
                    //, e.BillId, e.ProductId 
                });

                entity.HasOne(e => e.Bills)
                   .WithMany(e => e.InvoiceDetails)
                   .HasForeignKey(e => e.BillId)
                   .HasConstraintName("FK_InvoiceDetail_Bill");

                entity.HasOne(e => e.Pruducts)
                   .WithMany(e => e.InvoiceDetails)
                   .HasForeignKey(e => e.ProductId)
                   .HasConstraintName("FK_InvoiceDetail_Product");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                entity.HasKey(e => new { e.Id
                    //, e.GroupId, e.GoodsId
                });

                entity.HasOne(e => e.Groups)
                   .WithMany(e => e.Products)
                   .HasForeignKey(e => e.GroupId)
                   .HasConstraintName("FK_Product_Group");
                entity.HasOne(e => e.Goodss)
                   .WithMany(e => e.Products)
                   .HasForeignKey(e => e.GoodsId)
                   .HasConstraintName("FK_Product_Goods");
            });
        }
    }

}
