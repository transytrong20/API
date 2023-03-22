﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Data.Entity.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TokenCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAdmin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("API.Data.Entity.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("TransportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("customer_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("payment_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("transport_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("customer_id");

                    b.HasIndex("payment_id");

                    b.HasIndex("transport_id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("API.Data.Entity.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("User");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("API.Data.Entity.FeedBack", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FeedbackContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplyToFeedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponseHeaders")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("customer_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("customer_id");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("API.Data.Entity.Goods", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GoodsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Goodss");
                });

            modelBuilder.Entity("API.Data.Entity.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("API.Data.Entity.InvoiceDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid>("BillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PruductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<Guid>("bill_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("product_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("bill_id");

                    b.HasIndex("product_id");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("API.Data.Entity.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("API.Data.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GoodsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("goods_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("group_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("goods_id");

                    b.HasIndex("group_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("API.Data.Entity.Transport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TransportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("API.Data.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TokenCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Data.Entity.Bill", b =>
                {
                    b.HasOne("API.Data.Entity.Customer", "Customers")
                        .WithMany("Bills")
                        .HasForeignKey("customer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Data.Entity.Payment", "Payments")
                        .WithMany("Bills")
                        .HasForeignKey("payment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Data.Entity.Transport", "Transports")
                        .WithMany("Bills")
                        .HasForeignKey("transport_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Payments");

                    b.Navigation("Transports");
                });

            modelBuilder.Entity("API.Data.Entity.Customer", b =>
                {
                    b.HasOne("API.Data.Entity.User", "Users")
                        .WithMany("Tickets")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("API.Data.Entity.FeedBack", b =>
                {
                    b.HasOne("API.Data.Entity.Customer", "CustomerCustomer")
                        .WithMany("FeedBacks")
                        .HasForeignKey("customer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerCustomer");
                });

            modelBuilder.Entity("API.Data.Entity.InvoiceDetail", b =>
                {
                    b.HasOne("API.Data.Entity.Bill", "Bills")
                        .WithMany("Invoices")
                        .HasForeignKey("bill_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Data.Entity.Product", "Pruducts")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bills");

                    b.Navigation("Pruducts");
                });

            modelBuilder.Entity("API.Data.Entity.Product", b =>
                {
                    b.HasOne("API.Data.Entity.Goods", "Goodss")
                        .WithMany("Products")
                        .HasForeignKey("goods_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Data.Entity.Group", "Groups")
                        .WithMany("Products")
                        .HasForeignKey("group_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goodss");

                    b.Navigation("Groups");
                });

            modelBuilder.Entity("API.Data.Entity.Bill", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("API.Data.Entity.Customer", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("FeedBacks");
                });

            modelBuilder.Entity("API.Data.Entity.Goods", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("API.Data.Entity.Group", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("API.Data.Entity.Payment", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("API.Data.Entity.Product", b =>
                {
                    b.Navigation("InvoiceDetails");
                });

            modelBuilder.Entity("API.Data.Entity.Transport", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("API.Data.Entity.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
