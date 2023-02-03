using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeanstalkNet.Migrations
{
    /// <inheritdoc />
    public partial class Inittable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreatedOn", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Finish Youtube video", new DateTime(2023, 1, 30, 13, 46, 1, 173, DateTimeKind.Utc).AddTicks(4919), new DateTime(2023, 1, 30, 13, 46, 1, 173, DateTimeKind.Utc).AddTicks(4919) },
                    { 2, "Go to gym", new DateTime(2023, 1, 30, 13, 46, 1, 173, DateTimeKind.Utc).AddTicks(4919), new DateTime(2023, 1, 30, 13, 46, 1, 173, DateTimeKind.Utc).AddTicks(4919) },
                    { 3, "Go to grocery", new DateTime(2023, 1, 30, 13, 46, 1, 173, DateTimeKind.Utc).AddTicks(4919), new DateTime(2023, 1, 30, 13, 46, 1, 173, DateTimeKind.Utc).AddTicks(4919) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
