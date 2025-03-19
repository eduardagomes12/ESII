using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESII.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_convite_projeto_ProjetoId",
                table: "convite");

            migrationBuilder.DropForeignKey(
                name: "FK_convite_utilizador_UtilizadorId",
                table: "convite");

            migrationBuilder.RenameColumn(
                name: "UtilizadorId",
                table: "convite",
                newName: "utilizadorid");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "convite",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "ProjetoId",
                table: "convite",
                newName: "projetoid");

            migrationBuilder.RenameColumn(
                name: "DataResposta",
                table: "convite",
                newName: "dataresposta");

            migrationBuilder.RenameColumn(
                name: "DataEnvio",
                table: "convite",
                newName: "dataenvio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "convite",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_convite_UtilizadorId",
                table: "convite",
                newName: "IX_convite_utilizadorid");

            migrationBuilder.RenameIndex(
                name: "IX_convite_ProjetoId",
                table: "convite",
                newName: "IX_convite_projetoid");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "convite",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_convite_projeto_projetoid",
                table: "convite",
                column: "projetoid",
                principalTable: "projeto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_convite_utilizador_utilizadorid",
                table: "convite",
                column: "utilizadorid",
                principalTable: "utilizador",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_convite_projeto_projetoid",
                table: "convite");

            migrationBuilder.DropForeignKey(
                name: "FK_convite_utilizador_utilizadorid",
                table: "convite");

            migrationBuilder.RenameColumn(
                name: "utilizadorid",
                table: "convite",
                newName: "UtilizadorId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "convite",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "projetoid",
                table: "convite",
                newName: "ProjetoId");

            migrationBuilder.RenameColumn(
                name: "dataresposta",
                table: "convite",
                newName: "DataResposta");

            migrationBuilder.RenameColumn(
                name: "dataenvio",
                table: "convite",
                newName: "DataEnvio");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "convite",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_convite_utilizadorid",
                table: "convite",
                newName: "IX_convite_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_convite_projetoid",
                table: "convite",
                newName: "IX_convite_ProjetoId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "convite",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_convite_projeto_ProjetoId",
                table: "convite",
                column: "ProjetoId",
                principalTable: "projeto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_convite_utilizador_UtilizadorId",
                table: "convite",
                column: "UtilizadorId",
                principalTable: "utilizador",
                principalColumn: "Id");
        }
    }
}
