﻿// <auto-generated />
using System;
using EcommerceProject.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EcommerceProject.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    [Migration("20220803164152_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EcommerceProject.models.Brand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BName")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("EcommerceProject.models.CPhone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerId");

                    b.ToTable("CPhone");
                });

            modelBuilder.Entity("EcommerceProject.models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("EcommerceProject.models.CartItems", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("CartId", "CustomerId");

                    b.HasIndex("ProductID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("EcommerceProject.models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatName")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EcommerceProject.models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EcommerceProject.models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("EcommerceProject.models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EcommerceProject.models.OrderDetials", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Detials");
                });

            modelBuilder.Entity("EcommerceProject.models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int?>("BrandID")
                        .HasColumnType("int");

                    b.Property<int>("CatID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscountID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CatID");

                    b.HasIndex("DiscountID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EcommerceProject.models.CPhone", b =>
                {
                    b.HasOne("EcommerceProject.models.Customer", "Customer")
                        .WithMany("CPhones")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EcommerceProject.models.Cart", b =>
                {
                    b.HasOne("EcommerceProject.models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EcommerceProject.models.CartItems", b =>
                {
                    b.HasOne("EcommerceProject.models.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceProject.models.Product", null)
                        .WithMany("Items")
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("EcommerceProject.models.Order", b =>
                {
                    b.HasOne("EcommerceProject.models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EcommerceProject.models.OrderDetials", b =>
                {
                    b.HasOne("EcommerceProject.models.Order", null)
                        .WithMany("OrderDetials")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceProject.models.Product", null)
                        .WithMany("OrderDetials")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EcommerceProject.models.Product", b =>
                {
                    b.HasOne("EcommerceProject.models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandID");

                    b.HasOne("EcommerceProject.models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceProject.models.Discount", "discount")
                        .WithMany("Products")
                        .HasForeignKey("DiscountID");

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("discount");
                });

            modelBuilder.Entity("EcommerceProject.models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EcommerceProject.models.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("EcommerceProject.models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EcommerceProject.models.Customer", b =>
                {
                    b.Navigation("CPhones");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("EcommerceProject.models.Discount", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EcommerceProject.models.Order", b =>
                {
                    b.Navigation("OrderDetials");
                });

            modelBuilder.Entity("EcommerceProject.models.Product", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("OrderDetials");
                });
#pragma warning restore 612, 618
        }
    }
}
