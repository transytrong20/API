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
        //public DbSet<User> Users { get; set; }
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
    }

}
