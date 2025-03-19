using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESII.Migrations
{
    /// <inheritdoc />
    public partial class AjusteFinalTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Convites_Projetos_ProjetoId",
                table: "Convites");

            migrationBuilder.DropForeignKey(
                name: "FK_Convites_Utilizadores_UtilizadorId",
                table: "Convites");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Clientes_ClienteId",
                table: "Projetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Utilizadores_UtilizadorId",
                table: "Projetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Relatorios_Utilizadores_UtilizadorId",
                table: "Relatorios");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatoriosProjetos_Clientes_ClienteId",
                table: "RelatoriosProjetos");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatoriosProjetos_Projetos_ProjetoId",
                table: "RelatoriosProjetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Projetos_ProjetoId",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_RelatoriosProjetos_RelatorioProjId",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Utilizadores_UtilizadorId",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_UtilizadoresProjetos_Projetos_ProjetoId",
                table: "UtilizadoresProjetos");

            migrationBuilder.DropForeignKey(
                name: "FK_UtilizadoresProjetos_Utilizadores_UtilizadorId",
                table: "UtilizadoresProjetos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UtilizadoresProjetos",
                table: "UtilizadoresProjetos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilizadores",
                table: "Utilizadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelatoriosProjetos",
                table: "RelatoriosProjetos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Relatorios",
                table: "Relatorios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projetos",
                table: "Projetos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Convites",
                table: "Convites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "UtilizadoresProjetos",
                newName: "utilizadorprojeto");

            migrationBuilder.RenameTable(
                name: "Utilizadores",
                newName: "utilizador");

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "tarefa");

            migrationBuilder.RenameTable(
                name: "RelatoriosProjetos",
                newName: "relatorioproj");

            migrationBuilder.RenameTable(
                name: "Relatorios",
                newName: "relatorio");

            migrationBuilder.RenameTable(
                name: "Projetos",
                newName: "projeto");

            migrationBuilder.RenameTable(
                name: "Convites",
                newName: "convite");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "cliente");

            migrationBuilder.RenameIndex(
                name: "IX_UtilizadoresProjetos_ProjetoId",
                table: "utilizadorprojeto",
                newName: "IX_utilizadorprojeto_ProjetoId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_UtilizadorId",
                table: "tarefa",
                newName: "IX_tarefa_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_RelatorioProjId",
                table: "tarefa",
                newName: "IX_tarefa_RelatorioProjId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_ProjetoId",
                table: "tarefa",
                newName: "IX_tarefa_ProjetoId");

            migrationBuilder.RenameIndex(
                name: "IX_RelatoriosProjetos_ProjetoId",
                table: "relatorioproj",
                newName: "IX_relatorioproj_ProjetoId");

            migrationBuilder.RenameIndex(
                name: "IX_RelatoriosProjetos_ClienteId",
                table: "relatorioproj",
                newName: "IX_relatorioproj_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Relatorios_UtilizadorId",
                table: "relatorio",
                newName: "IX_relatorio_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Projetos_UtilizadorId",
                table: "projeto",
                newName: "IX_projeto_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Projetos_ClienteId",
                table: "projeto",
                newName: "IX_projeto_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Convites_UtilizadorId",
                table: "convite",
                newName: "IX_convite_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Convites_ProjetoId",
                table: "convite",
                newName: "IX_convite_ProjetoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_utilizadorprojeto",
                table: "utilizadorprojeto",
                columns: new[] { "UtilizadorId", "ProjetoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_utilizador",
                table: "utilizador",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tarefa",
                table: "tarefa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_relatorioproj",
                table: "relatorioproj",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_relatorio",
                table: "relatorio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projeto",
                table: "projeto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_convite",
                table: "convite",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente",
                table: "cliente",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_projeto_cliente_ClienteId",
                table: "projeto",
                column: "ClienteId",
                principalTable: "cliente",
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
                name: "FK_relatorioproj_cliente_ClienteId",
                table: "relatorioproj",
                column: "ClienteId",
                principalTable: "cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_relatorioproj_projeto_ProjetoId",
                table: "relatorioproj",
                column: "ProjetoId",
                principalTable: "projeto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tarefa_projeto_ProjetoId",
                table: "tarefa",
                column: "ProjetoId",
                principalTable: "projeto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tarefa_relatorioproj_RelatorioProjId",
                table: "tarefa",
                column: "RelatorioProjId",
                principalTable: "relatorioproj",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tarefa_utilizador_UtilizadorId",
                table: "tarefa",
                column: "UtilizadorId",
                principalTable: "utilizador",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_utilizadorprojeto_projeto_ProjetoId",
                table: "utilizadorprojeto",
                column: "ProjetoId",
                principalTable: "projeto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_utilizadorprojeto_utilizador_UtilizadorId",
                table: "utilizadorprojeto",
                column: "UtilizadorId",
                principalTable: "utilizador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_convite_projeto_ProjetoId",
                table: "convite");

            migrationBuilder.DropForeignKey(
                name: "FK_convite_utilizador_UtilizadorId",
                table: "convite");

            migrationBuilder.DropForeignKey(
                name: "FK_projeto_cliente_ClienteId",
                table: "projeto");

            migrationBuilder.DropForeignKey(
                name: "FK_projeto_utilizador_UtilizadorId",
                table: "projeto");

            migrationBuilder.DropForeignKey(
                name: "FK_relatorio_utilizador_UtilizadorId",
                table: "relatorio");

            migrationBuilder.DropForeignKey(
                name: "FK_relatorioproj_cliente_ClienteId",
                table: "relatorioproj");

            migrationBuilder.DropForeignKey(
                name: "FK_relatorioproj_projeto_ProjetoId",
                table: "relatorioproj");

            migrationBuilder.DropForeignKey(
                name: "FK_tarefa_projeto_ProjetoId",
                table: "tarefa");

            migrationBuilder.DropForeignKey(
                name: "FK_tarefa_relatorioproj_RelatorioProjId",
                table: "tarefa");

            migrationBuilder.DropForeignKey(
                name: "FK_tarefa_utilizador_UtilizadorId",
                table: "tarefa");

            migrationBuilder.DropForeignKey(
                name: "FK_utilizadorprojeto_projeto_ProjetoId",
                table: "utilizadorprojeto");

            migrationBuilder.DropForeignKey(
                name: "FK_utilizadorprojeto_utilizador_UtilizadorId",
                table: "utilizadorprojeto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_utilizadorprojeto",
                table: "utilizadorprojeto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_utilizador",
                table: "utilizador");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tarefa",
                table: "tarefa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_relatorioproj",
                table: "relatorioproj");

            migrationBuilder.DropPrimaryKey(
                name: "PK_relatorio",
                table: "relatorio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projeto",
                table: "projeto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_convite",
                table: "convite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

            migrationBuilder.RenameTable(
                name: "utilizadorprojeto",
                newName: "UtilizadoresProjetos");

            migrationBuilder.RenameTable(
                name: "utilizador",
                newName: "Utilizadores");

            migrationBuilder.RenameTable(
                name: "tarefa",
                newName: "Tarefas");

            migrationBuilder.RenameTable(
                name: "relatorioproj",
                newName: "RelatoriosProjetos");

            migrationBuilder.RenameTable(
                name: "relatorio",
                newName: "Relatorios");

            migrationBuilder.RenameTable(
                name: "projeto",
                newName: "Projetos");

            migrationBuilder.RenameTable(
                name: "convite",
                newName: "Convites");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_utilizadorprojeto_ProjetoId",
                table: "UtilizadoresProjetos",
                newName: "IX_UtilizadoresProjetos_ProjetoId");

            migrationBuilder.RenameIndex(
                name: "IX_tarefa_UtilizadorId",
                table: "Tarefas",
                newName: "IX_Tarefas_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_tarefa_RelatorioProjId",
                table: "Tarefas",
                newName: "IX_Tarefas_RelatorioProjId");

            migrationBuilder.RenameIndex(
                name: "IX_tarefa_ProjetoId",
                table: "Tarefas",
                newName: "IX_Tarefas_ProjetoId");

            migrationBuilder.RenameIndex(
                name: "IX_relatorioproj_ProjetoId",
                table: "RelatoriosProjetos",
                newName: "IX_RelatoriosProjetos_ProjetoId");

            migrationBuilder.RenameIndex(
                name: "IX_relatorioproj_ClienteId",
                table: "RelatoriosProjetos",
                newName: "IX_RelatoriosProjetos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_relatorio_UtilizadorId",
                table: "Relatorios",
                newName: "IX_Relatorios_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_projeto_UtilizadorId",
                table: "Projetos",
                newName: "IX_Projetos_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_projeto_ClienteId",
                table: "Projetos",
                newName: "IX_Projetos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_convite_UtilizadorId",
                table: "Convites",
                newName: "IX_Convites_UtilizadorId");

            migrationBuilder.RenameIndex(
                name: "IX_convite_ProjetoId",
                table: "Convites",
                newName: "IX_Convites_ProjetoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UtilizadoresProjetos",
                table: "UtilizadoresProjetos",
                columns: new[] { "UtilizadorId", "ProjetoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilizadores",
                table: "Utilizadores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelatoriosProjetos",
                table: "RelatoriosProjetos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relatorios",
                table: "Relatorios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projetos",
                table: "Projetos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Convites",
                table: "Convites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Convites_Projetos_ProjetoId",
                table: "Convites",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Convites_Utilizadores_UtilizadorId",
                table: "Convites",
                column: "UtilizadorId",
                principalTable: "Utilizadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Clientes_ClienteId",
                table: "Projetos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Utilizadores_UtilizadorId",
                table: "Projetos",
                column: "UtilizadorId",
                principalTable: "Utilizadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Relatorios_Utilizadores_UtilizadorId",
                table: "Relatorios",
                column: "UtilizadorId",
                principalTable: "Utilizadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatoriosProjetos_Clientes_ClienteId",
                table: "RelatoriosProjetos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatoriosProjetos_Projetos_ProjetoId",
                table: "RelatoriosProjetos",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Projetos_ProjetoId",
                table: "Tarefas",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_RelatoriosProjetos_RelatorioProjId",
                table: "Tarefas",
                column: "RelatorioProjId",
                principalTable: "RelatoriosProjetos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Utilizadores_UtilizadorId",
                table: "Tarefas",
                column: "UtilizadorId",
                principalTable: "Utilizadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UtilizadoresProjetos_Projetos_ProjetoId",
                table: "UtilizadoresProjetos",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UtilizadoresProjetos_Utilizadores_UtilizadorId",
                table: "UtilizadoresProjetos",
                column: "UtilizadorId",
                principalTable: "Utilizadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
