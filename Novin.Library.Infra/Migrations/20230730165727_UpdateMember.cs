using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Novin.Library.Infra.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BooksBorrowed",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BooksBorrowed",
                table: "Members");
        }
    }
}
