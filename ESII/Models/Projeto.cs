using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESII.Models
{
    public class Projeto
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        public int? UtilizadorId { get; set; }
        public Utilizador? Utilizador { get; set; }

        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public ICollection<Tarefa>? Tarefas { get; set; }
        public ICollection<Convite>? Convites { get; set; }
    }
}