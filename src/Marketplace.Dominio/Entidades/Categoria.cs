using System.ComponentModel.DataAnnotations;

namespace Marketplace.Dominio.Entidades
{
    public class Categoria
    {
        [Key]
        public Guid Codigo { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }
}
