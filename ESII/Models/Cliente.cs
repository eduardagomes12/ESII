using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESII.Models
{
    [Table("cliente")] // Confirma que a tabela chama "cliente"
    public class Cliente
    {
        [Key]
        [Column("id")] // Certifique-se que está correto!
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("telefone")]
        public string? Telefone { get; set; }
    }
}