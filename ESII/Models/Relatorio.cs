using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ESII.Models;

namespace ESII.Models
{
    public class Relatorio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Mes { get; set; }

        [Required]
        public int Ano { get; set; }

        public decimal? TotalHoras { get; set; }
        public decimal? PrecoTotal { get; set; }
        public decimal? PrecoHora { get; set; }

        public int? UtilizadorId { get; set; }
        public Utilizador? Utilizador { get; set; }
    }
}