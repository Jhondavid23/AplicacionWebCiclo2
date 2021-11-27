using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bicicleta_persona_clienteId",
                table: "bicicleta");

            migrationBuilder.DropForeignKey(
                name: "FK_visita_bicicleta_Bicicletaid",
                table: "visita");

            migrationBuilder.DropForeignKey(
                name: "FK_visita_persona_EmpleadoId",
                table: "visita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visita",
                table: "visita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bicicleta",
                table: "bicicleta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_persona",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "direccion",
                table: "persona");

            migrationBuilder.RenameTable(
                name: "visita",
                newName: "Visita");

            migrationBuilder.RenameTable(
                name: "bicicleta",
                newName: "Bicicleta");

            migrationBuilder.RenameTable(
                name: "persona",
                newName: "Empleado");

            migrationBuilder.RenameIndex(
                name: "IX_visita_EmpleadoId",
                table: "Visita",
                newName: "IX_Visita_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_visita_Bicicletaid",
                table: "Visita",
                newName: "IX_Visita_Bicicletaid");

            migrationBuilder.RenameIndex(
                name: "IX_bicicleta_clienteId",
                table: "Bicicleta",
                newName: "IX_Bicicleta_clienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visita",
                table: "Visita",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bicicleta",
                table: "Bicicleta",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Bicicleta_Clientes_clienteId",
                table: "Bicicleta",
                column: "clienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visita_Bicicleta_Bicicletaid",
                table: "Visita",
                column: "Bicicletaid",
                principalTable: "Bicicleta",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visita_Empleado_EmpleadoId",
                table: "Visita",
                column: "EmpleadoId",
                principalTable: "Empleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bicicleta_Clientes_clienteId",
                table: "Bicicleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Visita_Bicicleta_Bicicletaid",
                table: "Visita");

            migrationBuilder.DropForeignKey(
                name: "FK_Visita_Empleado_EmpleadoId",
                table: "Visita");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visita",
                table: "Visita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bicicleta",
                table: "Bicicleta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado");

            migrationBuilder.RenameTable(
                name: "Visita",
                newName: "visita");

            migrationBuilder.RenameTable(
                name: "Bicicleta",
                newName: "bicicleta");

            migrationBuilder.RenameTable(
                name: "Empleado",
                newName: "persona");

            migrationBuilder.RenameIndex(
                name: "IX_Visita_EmpleadoId",
                table: "visita",
                newName: "IX_visita_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Visita_Bicicletaid",
                table: "visita",
                newName: "IX_visita_Bicicletaid");

            migrationBuilder.RenameIndex(
                name: "IX_Bicicleta_clienteId",
                table: "bicicleta",
                newName: "IX_bicicleta_clienteId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_visita",
                table: "visita",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bicicleta",
                table: "bicicleta",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_persona",
                table: "persona",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bicicleta_persona_clienteId",
                table: "bicicleta",
                column: "clienteId",
                principalTable: "persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_visita_bicicleta_Bicicletaid",
                table: "visita",
                column: "Bicicletaid",
                principalTable: "bicicleta",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_visita_persona_EmpleadoId",
                table: "visita",
                column: "EmpleadoId",
                principalTable: "persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
