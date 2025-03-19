using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESII.Models
{
    [Table("convite")]  // Define explicitamente o nome correto da tabela
    public class Convite
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("status")]
        public string? Status { get; set; }

        [Column("dataenvio")]
        public DateTime? DataEnvio { get; set; }

        [Column("dataresposta")]
        public DateTime? DataResposta { get; set; }

        [Column("utilizadorid")]
        public int? UtilizadorId { get; set; }

        [Column("projetoid")]
        public int? ProjetoId { get; set; }
    }
}