﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicShop.DataAccess.Data;

#nullable disable

namespace MusicShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240413111052_AddImageUrlPropToProductsDb")]
    partial class AddImageUrlPropToProductsDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MusicShop.Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Keyboards"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Guitars"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Drums and Percussion"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "String Instruments"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Bass Guitars"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Microphones"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Headphones"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Accessories"
                        });
                });

            modelBuilder.Entity("MusicShop.Models.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ImageUrl = "",
                            ListPrice = 99.0,
                            Name = "Piano"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ImageUrl = "",
                            ListPrice = 40.0,
                            Name = "Electro guitar"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ImageUrl = "",
                            ListPrice = 55.0,
                            Name = "Drums"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Name = "Cello"
                        });
                });

            modelBuilder.Entity("MusicShop.Models.Models.Product", b =>
                {
                    b.HasOne("MusicShop.Models.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
