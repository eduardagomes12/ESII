using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ESII.Models;

namespace ESII.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        public decimal? Preco { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        public int? ProjetoId { get; set; }
        public Projeto? Projeto { get; set; }

        public int? UtilizadorId { get; set; }
        public Utilizador? Utilizador { get; set; }

        public int? RelatorioProjId { get; set; }
        public RelatorioProj? RelatorioProj { get; set; }
    }
}