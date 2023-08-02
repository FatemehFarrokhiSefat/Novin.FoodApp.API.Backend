using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Novin.Library.Infra.Migrations
{
    /// <inheritdoc />
    public partial class eborrow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Return",
                table: "Borrows",
                newName: "ReturnTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReturnTime",
                table: "Borrows",
                newName: "Return");
        }
    }
}
