using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                name: "FK_convite_utilizador_UtilizadorId",
                table: "convite");

            migrationBuilder.DropForeignKey(
                name: "FK_projeto_utilizador_UtilizadorId",
                table: "projeto");

            migrationBuilder.DropForeignKey(
                name: "FK_relatorio_utilizador_UtilizadorId",
                table: "relatorio");

            migrationBuilder.DropForeignKey(
                name: "FK_tarefa_utilizador_UtilizadorId",
                table: "tarefa");

            migrationBuilder.DropForeignKey(
                name: "FK_utilizadorprojeto_utilizador_UtilizadorId",
                table: "utilizadorprojeto");

            migrationBuilder.DropIndex(
                name: "IX_tarefa_UtilizadorId",
                table: "tarefa");

            migrationBuilder.DropIndex(
                name: "IX_relatorio_UtilizadorId",
                table: "relatorio");

            migrationBuilder.DropIndex(
                name: "IX_projeto_UtilizadorId",
                table: "projeto");

            migrationBuilder.DropIndex(
                name: "IX_convite_UtilizadorId",
                table: "convite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_utilizador",
                table: "utilizador");

            migrationBuilder.RenameTable(
                name: "utilizador",
                newName: "AspNetUsers");

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

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorId1",
                table: "utilizadorprojeto",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorId1",
                table: "tarefa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorId1",
                table: "relatorio",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorId1",
                table: "projeto",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorId1",
                table: "convite",
                type: "text",
                nullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_utilizadorprojeto_UtilizadorId1",
                table: "utilizadorprojeto",
                column: "UtilizadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_tarefa_UtilizadorId1",
                table: "tarefa",
                column: "UtilizadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_UtilizadorId1",
                table: "relatorio",
                column: "UtilizadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_UtilizadorId1",
                table: "projeto",
                column: "UtilizadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_convite_UtilizadorId1",
                table: "convite",
                column: "UtilizadorId1");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_convite_AspNetUsers_UtilizadorId1",
                table: "convite",
                column: "UtilizadorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_projeto_AspNetUsers_UtilizadorId1",
                table: "projeto",
                column: "UtilizadorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_relatorio_AspNetUsers_UtilizadorId1",
                table: "relatorio",
                column: "UtilizadorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tarefa_AspNetUsers_UtilizadorId1",
                table: "tarefa",
                column: "UtilizadorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_utilizadorprojeto_AspNetUsers_UtilizadorId1",
                table: "utilizadorprojeto",
                column: "UtilizadorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_convite_AspNetUsers_UtilizadorId1",
                table: "convite");

            migrationBuilder.DropForeignKey(
                name: "FK_projeto_AspNetUsers_UtilizadorId1",
                table: "projeto");

            migrationBuilder.DropForeignKey(
                name: "FK_relatorio_AspNetUsers_UtilizadorId1",
                table: "relatorio");

            migrationBuilder.DropForeignKey(
                name: "FK_tarefa_AspNetUsers_UtilizadorId1",
                table: "tarefa");

            migrationBuilder.DropForeignKey(
                name: "FK_utilizadorprojeto_AspNetUsers_UtilizadorId1",
                table: "utilizadorprojeto");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_utilizadorprojeto_UtilizadorId1",
                table: "utilizadorprojeto");

            migrationBuilder.DropIndex(
                name: "IX_tarefa_UtilizadorId1",
                table: "tarefa");

            migrationBuilder.DropIndex(
                name: "IX_relatorio_UtilizadorId1",
                table: "relatorio");

            migrationBuilder.DropIndex(
                name: "IX_projeto_UtilizadorId1",
                table: "projeto");

            migrationBuilder.DropIndex(
                name: "IX_convite_UtilizadorId1",
                table: "convite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UtilizadorId1",
                table: "utilizadorprojeto");

            migrationBuilder.DropColumn(
                name: "UtilizadorId1",
                table: "tarefa");

            migrationBuilder.DropColumn(
                name: "UtilizadorId1",
                table: "relatorio");

            migrationBuilder.DropColumn(
                name: "UtilizadorId1",
                table: "projeto");

            migrationBuilder.DropColumn(
                name: "UtilizadorId1",
                table: "convite");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "utilizador");

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

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "utilizador",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "utilizador",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_utilizador",
                table: "utilizador",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tarefa_UtilizadorId",
                table: "tarefa",
                column: "UtilizadorId");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_UtilizadorId",
                table: "relatorio",
                column: "UtilizadorId");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_UtilizadorId",
                table: "projeto",
                column: "UtilizadorId");

            migrationBuilder.CreateIndex(
                name: "IX_convite_UtilizadorId",
                table: "convite",
                column: "UtilizadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_convite_utilizador_UtilizadorId",
                table: "convite",
                column: "UtilizadorId",
                principalTable: "utilizador",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_projeto_utilizador_UtilizadorId",
                table: "projeto",
                column: "UtilizadorId",
                principalTable: "utilizador",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_relatorio_utilizador_UtilizadorId",
                table: "relatorio",
                column: "UtilizadorId",
                principalTable: "utilizador",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tarefa_utilizador_UtilizadorId",
                table: "tarefa",
                column: "UtilizadorId",
                principalTable: "utilizador",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_utilizadorprojeto_utilizador_UtilizadorId",
                table: "utilizadorprojeto",
                column: "UtilizadorId",
                principalTable: "utilizador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
