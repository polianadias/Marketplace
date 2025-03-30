using System.ComponentModel.DataAnnotations;

namespace Marketplace.Dominio.Entidades
{
    public class Produto
    {
        [Key]
        public Guid Codigo { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
