using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aromas_verão.Migrations
{
    /// <inheritdoc />
    public partial class MaisVendidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MaisVendidos",
                table: "Produtos",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaisVendidos",
                table: "Produtos");
        }
    }
}
