using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Kono Amenity e nai ashole villa e nai", new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8724), "nothig to say...", "https://www.pinterest.com/pin/420242208976678652/", "Boshundhora OiGhor", 10, 200202.0, 5000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Private pool, lakeside deck, and spacious living areas", new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8737), "A tranquil retreat by the lake with stunning views.", "https://www.pinterest.com/pin/420242208976678652/", "Lakeside Retreat", 8, 180000.0, 4500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Infinity pool, rooftop terrace, and beachfront access", new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8739), "Experience breathtaking sunsets from this luxurious paradise.", "https://www.pinterest.com/pin/420242208976678652/", "Sunset Paradise", 12, 250000.0, 6000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Spa, hiking trails, and panoramic mountain views", new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8742), "Escape to a serene haven surrounded by picturesque mountains.", "https://www.pinterest.com/pin/420242208976678652/", "Mountain View Haven", 6, 150000.0, 4000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Private garden, outdoor dining, and meditation pavilion", new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8744), "A lush garden oasis offering peace and tranquility.", "https://www.pinterest.com/pin/420242208976678652/", "Garden Oasis Villa", 10, 220000.0, 5500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Private beach access, sea-view balconies, and water sports", new DateTime(2024, 1, 11, 1, 23, 24, 490, DateTimeKind.Local).AddTicks(8745), "Unwind in a coastal retreat with sandy beaches and ocean breeze.", "https://www.pinterest.com/pin/420242208976678652/", "Coastal Escape", 14, 280000.0, 7000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
