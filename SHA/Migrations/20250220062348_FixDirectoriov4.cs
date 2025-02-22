using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHA.Migrations
{
    /// <inheritdoc />
    public partial class FixDirectoriov4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directorios_Departamentos_DepartamentoId",
                table: "Directorios");

            migrationBuilder.DropIndex(
                name: "IX_Directorios_DepartamentoId",
                table: "Directorios");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Directorios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartamentoId",
                table: "Directorios",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Directorios_DepartamentoId",
                table: "Directorios",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directorios_Departamentos_DepartamentoId",
                table: "Directorios",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id");
        }
    }
}
