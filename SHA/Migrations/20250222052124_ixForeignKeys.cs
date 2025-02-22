using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHA.Migrations
{
    /// <inheritdoc />
    public partial class ixForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquiposDaniados_Departamentos_DepartamentoId",
                table: "EquiposDaniados");

            migrationBuilder.DropForeignKey(
                name: "FK_EquiposDaniados_Empresas_EmpresaId",
                table: "EquiposDaniados");

            migrationBuilder.DropForeignKey(
                name: "FK_EquiposDaniados_Usuarios_UsuarioId",
                table: "EquiposDaniados");

            migrationBuilder.DropForeignKey(
                name: "FK_LineaTelefonos_Departamentos_DepartamentoId",
                table: "LineaTelefonos");

            migrationBuilder.DropForeignKey(
                name: "FK_LineaTelefonos_Usuarios_UsuarioId",
                table: "LineaTelefonos");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitores_Departamentos_DepartamentoId",
                table: "Monitores");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitores_Empresas_EmpresaId",
                table: "Monitores");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitores_Usuarios_UsuarioId",
                table: "Monitores");

            migrationBuilder.DropForeignKey(
                name: "FK_Moviles_Departamentos_DepartamentoId",
                table: "Moviles");

            migrationBuilder.DropForeignKey(
                name: "FK_Moviles_Empresas_EmpresaId",
                table: "Moviles");

            migrationBuilder.DropForeignKey(
                name: "FK_Moviles_Usuarios_UsuarioId",
                table: "Moviles");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Departamentos_DepartamentoId",
                table: "Telefonos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Usuarios_UsuarioId",
                table: "Telefonos");

            migrationBuilder.DropIndex(
                name: "IX_Telefonos_DepartamentoId",
                table: "Telefonos");

            migrationBuilder.DropIndex(
                name: "IX_Telefonos_UsuarioId",
                table: "Telefonos");

            migrationBuilder.DropIndex(
                name: "IX_Moviles_DepartamentoId",
                table: "Moviles");

            migrationBuilder.DropIndex(
                name: "IX_Moviles_EmpresaId",
                table: "Moviles");

            migrationBuilder.DropIndex(
                name: "IX_Moviles_UsuarioId",
                table: "Moviles");

            migrationBuilder.DropIndex(
                name: "IX_Monitores_DepartamentoId",
                table: "Monitores");

            migrationBuilder.DropIndex(
                name: "IX_Monitores_EmpresaId",
                table: "Monitores");

            migrationBuilder.DropIndex(
                name: "IX_Monitores_UsuarioId",
                table: "Monitores");

            migrationBuilder.DropIndex(
                name: "IX_LineaTelefonos_DepartamentoId",
                table: "LineaTelefonos");

            migrationBuilder.DropIndex(
                name: "IX_LineaTelefonos_UsuarioId",
                table: "LineaTelefonos");

            migrationBuilder.DropIndex(
                name: "IX_EquiposDaniados_DepartamentoId",
                table: "EquiposDaniados");

            migrationBuilder.DropIndex(
                name: "IX_EquiposDaniados_EmpresaId",
                table: "EquiposDaniados");

            migrationBuilder.DropIndex(
                name: "IX_EquiposDaniados_UsuarioId",
                table: "EquiposDaniados");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Telefonos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Telefonos");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Moviles");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Moviles");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Moviles");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Monitores");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Monitores");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Monitores");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "LineaTelefonos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "LineaTelefonos");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "EquiposDaniados");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "EquiposDaniados");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "EquiposDaniados");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartamentoId",
                table: "Telefonos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Telefonos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartamentoId",
                table: "Moviles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpresaId",
                table: "Moviles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Moviles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartamentoId",
                table: "Monitores",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpresaId",
                table: "Monitores",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Monitores",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartamentoId",
                table: "LineaTelefonos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "LineaTelefonos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartamentoId",
                table: "EquiposDaniados",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpresaId",
                table: "EquiposDaniados",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "EquiposDaniados",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_DepartamentoId",
                table: "Telefonos",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_UsuarioId",
                table: "Telefonos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Moviles_DepartamentoId",
                table: "Moviles",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Moviles_EmpresaId",
                table: "Moviles",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Moviles_UsuarioId",
                table: "Moviles",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitores_DepartamentoId",
                table: "Monitores",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitores_EmpresaId",
                table: "Monitores",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitores_UsuarioId",
                table: "Monitores",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaTelefonos_DepartamentoId",
                table: "LineaTelefonos",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaTelefonos_UsuarioId",
                table: "LineaTelefonos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_DepartamentoId",
                table: "EquiposDaniados",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_EmpresaId",
                table: "EquiposDaniados",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_UsuarioId",
                table: "EquiposDaniados",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquiposDaniados_Departamentos_DepartamentoId",
                table: "EquiposDaniados",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EquiposDaniados_Empresas_EmpresaId",
                table: "EquiposDaniados",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EquiposDaniados_Usuarios_UsuarioId",
                table: "EquiposDaniados",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineaTelefonos_Departamentos_DepartamentoId",
                table: "LineaTelefonos",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineaTelefonos_Usuarios_UsuarioId",
                table: "LineaTelefonos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitores_Departamentos_DepartamentoId",
                table: "Monitores",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitores_Empresas_EmpresaId",
                table: "Monitores",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitores_Usuarios_UsuarioId",
                table: "Monitores",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moviles_Departamentos_DepartamentoId",
                table: "Moviles",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moviles_Empresas_EmpresaId",
                table: "Moviles",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moviles_Usuarios_UsuarioId",
                table: "Moviles",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Departamentos_DepartamentoId",
                table: "Telefonos",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Usuarios_UsuarioId",
                table: "Telefonos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
