using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESII.Migrations
{
    /// <inheritdoc />
    public partial class CorrigirTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "cliente",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "cliente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "cliente",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "cliente",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "cliente",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "cliente",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "cliente",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "cliente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "cliente",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "cliente",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "cliente",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
