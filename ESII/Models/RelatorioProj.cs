using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESII.Models
{
    public class RelatorioProj
    {
        [Key]
        public int Id { get; set; }

        public decimal? PrecoTarefas { get; set; }
        public decimal? PrecoTotal { get; set; }

        public int? ProjetoId { get; set; }
        public Projeto? Projeto { get; set; }

        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}