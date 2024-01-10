using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Boshundhora OiGhor",
                    Details = "nothig to say...",
                    ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                    Occupancy = 10,
                    Rate = 200202,
                    Sqft = 5000,
                    Amenity = "Kono Amenity e nai ashole villa e nai",
                    CreatedDate= DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Lakeside Retreat",
                    Details = "A tranquil retreat by the lake with stunning views.",
                    ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                    Occupancy = 8,
                    Rate = 180000,
                    Sqft = 4500,
                    Amenity = "Private pool, lakeside deck, and spacious living areas",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Sunset Paradise",
                    Details = "Experience breathtaking sunsets from this luxurious paradise.",
                    ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                    Occupancy = 12,
                    Rate = 250000,
                    Sqft = 6000,
                    Amenity = "Infinity pool, rooftop terrace, and beachfront access",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Mountain View Haven",
                    Details = "Escape to a serene haven surrounded by picturesque mountains.",
                    ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                    Occupancy = 6,
                    Rate = 150000,
                    Sqft = 4000,
                    Amenity = "Spa, hiking trails, and panoramic mountain views",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Garden Oasis Villa",
                    Details = "A lush garden oasis offering peace and tranquility.",
                    ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                    Occupancy = 10,
                    Rate = 220000,
                    Sqft = 5500,
                    Amenity = "Private garden, outdoor dining, and meditation pavilion",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 6,
                    Name = "Coastal Escape",
                    Details = "Unwind in a coastal retreat with sandy beaches and ocean breeze.",
                    ImageUrl = "https://www.pinterest.com/pin/420242208976678652/",
                    Occupancy = 14,
                    Rate = 280000,
                    Sqft = 7000,
                    Amenity = "Private beach access, sea-view balconies, and water sports",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
