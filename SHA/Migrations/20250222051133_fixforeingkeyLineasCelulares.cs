using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHA.Migrations
{
    /// <inheritdoc />
    public partial class fixforeingkeyLineasCelulares : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lineaCelulares_Departamentos_DepartamentoId",
                table: "lineaCelulares");

            migrationBuilder.DropForeignKey(
                name: "FK_lineaCelulares_Usuarios_UsuarioId",
                table: "lineaCelulares");

            migrationBuilder.DropIndex(
                name: "IX_lineaCelulares_DepartamentoId",
                table: "lineaCelulares");

            migrationBuilder.DropIndex(
                name: "IX_lineaCelulares_UsuarioId",
                table: "lineaCelulares");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "lineaCelulares");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "lineaCelulares");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartamentoId",
                table: "lineaCelulares",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "lineaCelulares",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_lineaCelulares_DepartamentoId",
                table: "lineaCelulares",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_lineaCelulares_UsuarioId",
                table: "lineaCelulares",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_lineaCelulares_Departamentos_DepartamentoId",
                table: "lineaCelulares",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_lineaCelulares_Usuarios_UsuarioId",
                table: "lineaCelulares",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
