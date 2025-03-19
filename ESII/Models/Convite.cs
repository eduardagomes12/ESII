using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ESII.Models;

namespace ESII.Models
{
    public class Convite
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        public DateTime? DataEnvio { get; set; }
        public DateTime? DataResposta { get; set; }

        public int? UtilizadorId { get; set; }
        public Utilizador? Utilizador { get; set; }

        public int? ProjetoId { get; set; }
        public Projeto? Projeto { get; set; }
    }
}