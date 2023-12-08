using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        public List <Produto> Produtos { get; set; }
    }
}