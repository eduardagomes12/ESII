using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ESII.Models
{
    public class Utilizador : IdentityUser
    {
        public int Id { get; set; }

        [Required, MaxLength(100)] public string Nome { get; set; } = string.Empty;

        [Required, MaxLength(255)]
        public string Password { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Email { get; set; }

        public decimal? HorasDia { get; set; }

        public ICollection<Projeto>? Projetos { get; set; }
        public ICollection<Tarefa>? Tarefas { get; set; }
        public ICollection<Convite>? Convites { get; set; }
        public ICollection<Relatorio>? Relatorios { get; set; }
    }
}