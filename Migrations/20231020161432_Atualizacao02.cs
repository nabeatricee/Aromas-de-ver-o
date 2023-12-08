using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aromas_verão.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaIdCategoria",
                table: "Produtos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaIdCategoria",
                table: "Produtos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaIdCategoria",
                table: "Produtos",
                column: "CategoriaIdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaIdCategoria",
                table: "Produtos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaIdCategoria",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaIdCategoria",
                table: "Produtos",
                column: "CategoriaIdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
