using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace App.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Descrição do Produto")]
        public string Descricao { get; set; }

        [Display(Name = "Foto do Produto")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        [Display(Name = "Preço do Produto")]
        public float Valor { get; set; }

        public bool MaisVendidos { get; set; }

        
        public int IdCategoria { get; set; }
        //public virtual Categoria Categoria { get; set; }
    }
}