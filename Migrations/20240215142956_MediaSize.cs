using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_api.Migrations
{
    /// <inheritdoc />
    public partial class MediaSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Media");

            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "Media",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Media");

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Media",
                type: "bytea",
                nullable: true);
        }
    }
}
