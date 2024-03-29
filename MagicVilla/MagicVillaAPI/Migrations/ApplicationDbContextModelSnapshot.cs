﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Kono Amenity e nai ashole villa e nai",
                            CreatedDate = new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8724),
                            Details = "nothig to say...",
                            ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                            Name = "Boshundhora OiGhor",
                            Occupancy = 10,
                            Rate = 200202.0,
                            Sqft = 5000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Private pool, lakeside deck, and spacious living areas",
                            CreatedDate = new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8737),
                            Details = "A tranquil retreat by the lake with stunning views.",
                            ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                            Name = "Lakeside Retreat",
                            Occupancy = 8,
                            Rate = 180000.0,
                            Sqft = 4500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Infinity pool, rooftop terrace, and beachfront access",
                            CreatedDate = new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8739),
                            Details = "Experience breathtaking sunsets from this luxurious paradise.",
                            ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                            Name = "Sunset Paradise",
                            Occupancy = 12,
                            Rate = 250000.0,
                            Sqft = 6000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Spa, hiking trails, and panoramic mountain views",
                            CreatedDate = new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8742),
                            Details = "Escape to a serene haven surrounded by picturesque mountains.",
                            ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                            Name = "Mountain View Haven",
                            Occupancy = 6,
                            Rate = 150000.0,
                            Sqft = 4000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Private garden, outdoor dining, and meditation pavilion",
                            CreatedDate = new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8744),
                            Details = "A lush garden oasis offering peace and tranquility.",
                            ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                            Name = "Garden Oasis Villa",
                            Occupancy = 10,
                            Rate = 220000.0,
                            Sqft = 5500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "Private beach access, sea-view balconies, and water sports",
                            CreatedDate = new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8745),
                            Details = "Unwind in a coastal retreat with sandy beaches and ocean breeze.",
                            ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                            Name = "Coastal Escape",
                            Occupancy = 14,
                            Rate = 280000.0,
                            Sqft = 7000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
