using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHA.Migrations
{
    /// <inheritdoc />
    public partial class FixDirectorio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NomDpto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Roles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computadoras",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomDispositivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacEthernet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacWifi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Procesador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ssd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computadoras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computadoras_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomDispositivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacEthernet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacWifi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Procesador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ssd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laptops_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tablets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacWifi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Cabina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tablets_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tablets_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRol = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Directorios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NivelUbicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cabina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directorios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Directorios_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Directorios_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Directorios_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquiposDaniados",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Equipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacEthernet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MacWifi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Procesador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartamentoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmpresaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquiposDaniados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquiposDaniados_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EquiposDaniados_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquiposDaniados_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EquiposDaniados_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquiposDaniados_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquiposDaniados_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "lineaCelulares",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lineaCelulares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lineaCelulares_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_lineaCelulares_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_lineaCelulares_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_lineaCelulares_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LineaTelefonos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineaTelefonos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineaTelefonos_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LineaTelefonos_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LineaTelefonos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LineaTelefonos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Monitores",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartamentoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmpresaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitores_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Monitores_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monitores_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Monitores_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monitores_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monitores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Moviles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imei = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumCelular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Megas = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PrecioPlan = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartamentoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmpresaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moviles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moviles_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Moviles_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Moviles_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Moviles_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Moviles_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Moviles_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cabina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartamentoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefonos_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Telefonos_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefonos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefonos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computadoras_IdEmpresa",
                table: "Computadoras",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Directorios_DepartamentoId",
                table: "Directorios",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Directorios_IdDepartamento",
                table: "Directorios",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Directorios_IdUsuario",
                table: "Directorios",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_DepartamentoId",
                table: "EquiposDaniados",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_EmpresaId",
                table: "EquiposDaniados",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_IdDepartamento",
                table: "EquiposDaniados",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_IdEmpresa",
                table: "EquiposDaniados",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_IdUsuario",
                table: "EquiposDaniados",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposDaniados_UsuarioId",
                table: "EquiposDaniados",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Laptops_IdEmpresa",
                table: "Laptops",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_lineaCelulares_DepartamentoId",
                table: "lineaCelulares",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_lineaCelulares_IdDepartamento",
                table: "lineaCelulares",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_lineaCelulares_IdUsuario",
                table: "lineaCelulares",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_lineaCelulares_UsuarioId",
                table: "lineaCelulares",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaTelefonos_DepartamentoId",
                table: "LineaTelefonos",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_LineaTelefonos_IdDepartamento",
                table: "LineaTelefonos",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_LineaTelefonos_IdUsuario",
                table: "LineaTelefonos",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_LineaTelefonos_UsuarioId",
                table: "LineaTelefonos",
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
                name: "IX_Monitores_IdDepartamento",
                table: "Monitores",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Monitores_IdEmpresa",
                table: "Monitores",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Monitores_IdUsuario",
                table: "Monitores",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Monitores_UsuarioId",
                table: "Monitores",
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
                name: "IX_Moviles_IdDepartamento",
                table: "Moviles",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Moviles_IdEmpresa",
                table: "Moviles",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Moviles_IdUsuario",
                table: "Moviles",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Moviles_UsuarioId",
                table: "Moviles",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tablets_IdDepartamento",
                table: "Tablets",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Tablets_IdEmpresa",
                table: "Tablets",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_DepartamentoId",
                table: "Telefonos",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_IdDepartamento",
                table: "Telefonos",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_IdUsuario",
                table: "Telefonos",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_UsuarioId",
                table: "Telefonos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdDepartamento",
                table: "Usuarios",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdRol",
                table: "Usuarios",
                column: "IdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computadoras");

            migrationBuilder.DropTable(
                name: "Directorios");

            migrationBuilder.DropTable(
                name: "EquiposDaniados");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "lineaCelulares");

            migrationBuilder.DropTable(
                name: "LineaTelefonos");

            migrationBuilder.DropTable(
                name: "Monitores");

            migrationBuilder.DropTable(
                name: "Moviles");

            migrationBuilder.DropTable(
                name: "Tablets");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
