using ESII.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ESII.Models
{
    public class AppDbContext : IdentityDbContext<Utilizador>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Convite> Convites { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<RelatorioProj> RelatoriosProjetos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<UtilizadorProjeto> UtilizadoresProjetos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeia as entidades para os nomes das tabelas existentes no PostgreSQL
            modelBuilder.Entity<Cliente>().ToTable("cliente");
            modelBuilder.Entity<Utilizador>().ToTable("utilizador");
            modelBuilder.Entity<Projeto>().ToTable("projeto");
            modelBuilder.Entity<Convite>().ToTable("convite");
            modelBuilder.Entity<Relatorio>().ToTable("relatorio");
            modelBuilder.Entity<RelatorioProj>().ToTable("relatorioproj");
            modelBuilder.Entity<Tarefa>().ToTable("tarefa");
            modelBuilder.Entity<UtilizadorProjeto>().ToTable("utilizadorprojeto");

            // Configuração de chave primária composta
            modelBuilder.Entity<UtilizadorProjeto>()
                .HasKey(up => new { up.UtilizadorId, up.ProjetoId });

            base.OnModelCreating(modelBuilder);
        }


        
    }
}